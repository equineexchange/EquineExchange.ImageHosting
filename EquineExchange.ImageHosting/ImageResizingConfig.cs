namespace EquineExchange.ImageHosting
{
    using System.Web;

    using ImageResizer.Configuration;
    using ImageResizer.Plugins.AzureReader2;
    using ImageResizer.Plugins.Basic;
    using ImageResizer.Plugins.DiskCache;

    public class ImageResizingConfig : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            SetupImageResizer(Config.Current);
        }

        public void Dispose()
        {
        }

        private static void SetupImageResizer(Config config)
        {
            if (ImageResizerSettings.License != null)
            {
                new StaticLicenseProvider(ImageResizerSettings.License).Install(config);
            }

            new AzureReader2Plugin(AzureReaderSettings.ToNameValueCollection()).Install(config);

            if (DiskCacheSettings.Enabled)
            {
                var diskCache = new DiskCache
                {
                    AsyncWrites = DiskCacheSettings.AsyncWrites
                };

                diskCache.Install(config);
            }
        }
    }
}
