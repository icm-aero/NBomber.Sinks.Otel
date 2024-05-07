namespace NBomber.Sinks.Otel;

public sealed class OtelSinkConfig
{
    public IReadOnlyCollection<string> HttpListenerPrefixes { get; set; } = new[] { "http://localhost:9464" };
    public string ScrapeEndpointPath { get; set; } = "/metrics";
    public CustomTag[] CustomTags { get; set; } = Array.Empty<CustomTag>();
}
