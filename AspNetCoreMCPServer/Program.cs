using AspNetCoreMCPServer.Tools;
using OKX.Api;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMcpServer()
    .WithHttpTransport()
    .WithTools<OKXTools>();

//builder.Services.AddOpenTelemetry()
//    .WithTracing(b => b.AddSource("*")
//        .AddAspNetCoreInstrumentation()
//        .AddHttpClientInstrumentation())
//    .WithMetrics(b => b.AddMeter("*")
//        .AddAspNetCoreInstrumentation()
//        .AddHttpClientInstrumentation())
//    .WithLogging()
//    .UseOtlpExporter();

builder.Services.AddSingleton<OkxRestApiClient>();

var app = builder.Build();


app.MapMcp();

app.Run();