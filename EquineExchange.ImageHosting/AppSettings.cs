namespace EquineExchange.ImageHosting
{
    using System;
    using System.Runtime.CompilerServices;

    using Microsoft.Azure;

    public static class AppSettings
    {
        public static string AzureReader([CallerMemberName] string settingName = null) => GetSectionString(settingName);

        public static string DiskCache([CallerMemberName] string settingName = null) => GetSectionString(settingName);

        public static string ImageResizer([CallerMemberName] string settingName = null) => GetSectionString(settingName);

        public static string GetString(string settingName, string defaultValue = null)
        {
            var temp = CloudConfigurationManager.GetSetting(settingName);

            if (string.IsNullOrWhiteSpace(temp))
            {
                return defaultValue;
            }

            return temp;
        }

        private static string GetSectionString(string settingName, [CallerMemberName] string sectionName = null)
        {
            var name = string.Concat("app:", FixCasing(sectionName), '.', FixCasing(settingName));

            return GetString(name);
        }

        private static string FixCasing(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));

            var chars = name.ToCharArray();

            chars[0] = char.ToLowerInvariant(chars[0]);

            return new string(chars);
        }
    }
}
