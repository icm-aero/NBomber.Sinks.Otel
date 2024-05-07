# NBomber Otel Sink

NBomber Otel Sink is a custom sink for NBomber load-testing framework. It integrates with Otel, a popular monitoring and alerting toolkit, allowing you to collect and visualize load testing metrics.

## Features

- Integrates NBomber with Otel for monitoring load test metrics.
- Provides predefined metrics for request latency, request counts, RPS, and more.
- Supports custom tags for fine-grained metric grouping.
- Easy setup and configuration.

### Installation

You can install the NBomber Otel Sink via NuGet. Run the following command in the NuGet Package Manager Console:
```code
PM> Install-Package NBomber.Sinks.Otel
```

### Usage

To use the NBomber Otel Sink, follow these steps:

1. Set up your load test scenario using NBomber.

2. Configure NBomber to use the Otel sink. Refer to the NBomber documentation for information on how to configure sinks.

3. Configure Otel job to scrape metrics from the NBomber Otel sink.

4. Run your load test.

For more details on configuring and using the NBomber Otel Sink, refer to the [samples](samples).

## Code Samples

Here's an example of how to set up a load test scenario with the NBomber Otel Sink:

```csharp
// Create a Otel Sink
var OtelSink = new OtelSink();

// Configure your scenario
var scenario = Scenario.Create("MyScenario", RadclientAuthenticateUser);

// Start the load test
NBomberRunner
    .RegisterScenarios(scenario)
    .WithReportingInterval(TimeSpan.FromSeconds(10)) // Default OpenTelemetry exporter reporting interval
    .WithReportingSinks(OtelSink)
    .Run()
```

For more code samples and examples, please refer to the [samples](samples) directory.

## How it works

NBomber.Sinks.Otel utilizes OpenTelemetry.Exporter.OpenTelemetryProtocol to export metrics.
During the execution of your load test, the sink creates an OTLP instance that listens on the `http://localhost:9464/metrics` endpoint by default.
Subsequently, the Otel job scrapes metrics by calling the endpoint.