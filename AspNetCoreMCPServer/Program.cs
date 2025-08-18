using System.Text.Json;
using AspNetCoreMCPServer.Clients;
using AspNetCoreMCPServer.Tools;
using OKX.Api;
using OpenTelemetry;
using OpenTelemetry.Metrics;
using OpenTelemetry.Trace;

var builder = WebApplication.CreateBuilder(args);
builder
    .Services.AddMcpServer()
    .WithHttpTransport()
    //.WithTools<OKXTools>()
    .WithTools<KlicklTools>();

builder
    .Services.AddOpenTelemetry()
    .WithTracing(b =>
        b.AddSource("*").AddAspNetCoreInstrumentation().AddHttpClientInstrumentation()
    )
    .WithMetrics(b => b.AddMeter("*").AddAspNetCoreInstrumentation().AddHttpClientInstrumentation())
    .WithLogging()
    .UseOtlpExporter();

builder.Services.AddSingleton<OkxRestApiClient>();
builder.Services.AddSingleton<KlicklFuturesClient>();
builder.Services.AddSingleton<KlicklSpotClient>();
builder.Services.AddHttpClient(
    "KlicklSpot",
    c =>
    {
        c.BaseAddress = new Uri("https://api.klicklx.com");
    }
);
builder.Services.AddHttpClient(
    "KlicklFutures",
    c =>
    {
        c.BaseAddress = new Uri("https://ctapi.klicklx.com");
    }
);
builder.Services.Configure<JsonSerializerOptions>(options =>
{
    options.PropertyNameCaseInsensitive = true;
});
builder.Services.AddHttpContextAccessor();
var app = builder.Build();
app.MapMcp();
app.Run();
