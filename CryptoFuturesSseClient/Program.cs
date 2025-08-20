using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;

var transport = new SseClientTransport(
    new SseClientTransportOptions
    {
        Endpoint = new Uri("http://localhost:10900/sse"),
        Name = "dotnet console client",
        TransportMode = HttpTransportMode.AutoDetect,
    }
);

var client = await McpClientFactory.CreateAsync(transport);
foreach (var tool in await client.ListToolsAsync())
{
    Console.WriteLine($"{tool.Name} ({tool.Description})");
}

var result = await client.CallToolAsync(
    "get_futures_real_time_handicap",
    new Dictionary<string, object?> { { "symbol", "BTCUSDT" } }
);

Console.WriteLine(((TextContentBlock)result.Content.First()).Text);
