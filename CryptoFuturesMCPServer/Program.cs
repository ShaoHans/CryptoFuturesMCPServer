using CryptoFuturesMCPServer.Tools;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OKX.Api;

var builder = Host.CreateApplicationBuilder(args);

// Configure all logs to go to stderr (stdout is used for the MCP protocol messages).
builder.Logging.AddConsole(o => o.LogToStandardErrorThreshold = LogLevel.Trace);

builder.Services.AddSingleton<OkxRestApiClient>();

// Add the MCP services: the transport to use (stdio) and the tools to register.
builder.Services.AddMcpServer().WithStdioServerTransport().WithTools<OKXTools>();

await builder.Build().RunAsync();
