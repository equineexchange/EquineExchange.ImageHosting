namespace EquineExchange.ImageHosting
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;

    public static class AzureReaderSettings
    {
        public static string Prefix { get; } = AppSettings.AzureReader("prefix");

        public static string ConnectionString { get; } = AppSettings.AzureReader("connectionString");

        public static string RedirectToBlobIfUnmodified { get; } = AppSettings.AzureReader("redirectToBlobIfUnmodified");

        public static string RequireImageExtension { get; } = AppSettings.AzureReader("requireImageExtension");

        public static string UntrustedData { get; } = AppSettings.AzureReader("untrustedData");

        public static NameValueCollection ToNameValueCollection()
        {
            return new NameValueCollection(StringComparer.OrdinalIgnoreCase)
            {
                { "prefix", Prefix },
                { "connectionString", ConnectionString },
                { "redirectToBlobIfUnmodified", RedirectToBlobIfUnmodified },
                { "requireImageExtension", RequireImageExtension },
                { "untrustedData", UntrustedData },
            };
        }
    }
}
