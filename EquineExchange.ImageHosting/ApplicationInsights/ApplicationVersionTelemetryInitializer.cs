namespace EquineExchange.ImageHosting.ApplicationInsights
{
    using Microsoft.ApplicationInsights.Channel;
    using Microsoft.ApplicationInsights.Extensibility;

    public class ApplicationVersionTelemetryInitializer: ITelemetryInitializer
    {
        public void Initialize(ITelemetry telemetry)
        {
            telemetry.Context.Component.Version = ApplicationInformation.Version;
        }
    }
}
