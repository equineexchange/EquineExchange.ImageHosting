namespace EquineExchange.ImageHosting
{
    using System;
    using System.Collections.Specialized;

    public static class AzureReaderSettings
    {
        public static string Prefix { get; } = AppSettings.AzureReader();

        public static string ConnectionString { get; } = AppSettings.AzureReader();

        public static string RedirectToBlobIfUnmodified { get; } = AppSettings.AzureReader();

        public static string RequireImageExtension { get; } = AppSettings.AzureReader();

        public static string UntrustedData { get; } = AppSettings.AzureReader();

        public static NameValueCollection ToNameValueCollection()
        {
            return new NameValueCollection(StringComparer.OrdinalIgnoreCase)
            {
                { nameof(Prefix), Prefix },
                { nameof(ConnectionString), ConnectionString },
                { nameof(RedirectToBlobIfUnmodified), RedirectToBlobIfUnmodified },
                { nameof(RequireImageExtension), RequireImageExtension },
                { nameof(UntrustedData), UntrustedData },
            };
        }
    }
}
