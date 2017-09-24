namespace EquineExchange.ImageHosting
{
    using System.Reflection;

    public static class ApplicationInformation
    {
        static ApplicationInformation()
        {
            var assembly = typeof(ApplicationInformation).Assembly;

            Version = assembly.GetCustomAttribute<AssemblyInformationalVersionAttribute>().InformationalVersion;
        }

        public static string Version { get; }
    }
}
