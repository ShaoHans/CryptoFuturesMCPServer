using ModelContextProtocol.Client;
using ModelContextProtocol.Protocol;

var projectRoot = Directory
    .GetParent(AppContext.BaseDirectory)
    ?.Parent?.Parent?.Parent?.Parent?.FullName;

var toolsPath = Path.Combine(
    projectRoot!,
    "CryptoFuturesMCPServer",
    "bin",
    "Debug",
    "net9.0",
    "CryptoFuturesMCPServer.dll"
);

var clientTransport = new StdioClientTransport(
    new StdioClientTransportOptions { Command = "dotnet", Arguments = new[] { toolsPath }, }
);

var client = await McpClientFactory.CreateAsync(clientTransport);
foreach (var tool in await client.ListToolsAsync())
{
    Console.WriteLine($"{tool.Name} ({tool.Description})");
}

var result = await client.CallToolAsync(
    "get_mark_price",
    new Dictionary<string, object?>() { ["symbol"] = "BTC-USDT" },
    cancellationToken: CancellationToken.None);

Console.WriteLine(((TextContentBlock)result.Content.First()).Text);
