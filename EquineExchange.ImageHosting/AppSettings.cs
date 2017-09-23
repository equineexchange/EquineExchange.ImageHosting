namespace EquineExchange.ImageHosting
{
    using Microsoft.Azure;

    public static class AppSettings
    {
        public static string AzureReader(string settingName) => GetString("app:azureReader." + settingName);

        public static string ImageResizer(string settingName) => GetString("app:imageResizer." + settingName);

        private static string GetString(string settingName, string defaultValue = null)
        {
            var temp = CloudConfigurationManager.GetSetting(settingName);

            if (string.IsNullOrWhiteSpace(temp))
            {
                temp = defaultValue;
            }

            return temp;
        }
    }
}
