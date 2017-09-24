namespace EquineExchange.ImageHosting
{
    using System.Web;

    using Microsoft.ApplicationInsights.Extensibility;

    public class ApplicationInsightsConfig : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            TelemetryConfiguration.Active.InstrumentationKey = AppSettings.GetString("APPINSIGHTS_INSTRUMENTATIONKEY", defaultValue: string.Empty);
        }

        public void Dispose()
        {
        }
    }
}
