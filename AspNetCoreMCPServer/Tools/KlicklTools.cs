using System.ComponentModel;
using AspNetCoreMCPServer.Clients;
using AspNetCoreMCPServer.Clients.Models;
using ModelContextProtocol.Server;

namespace AspNetCoreMCPServer.Tools;

internal sealed class KlicklTools(KlicklFuturesClient klicklFuturesClient)
{
    [McpServerTool]
    [Description("Retrieve specified futures symbol real-time market data from Klickl.")]
    public async Task<FuturesRealTimeHandicapDto?> GetFuturesRealTimeHandicapAsync(
        [Description("the futures symbol")] string symbol
    )
    {
        return (await klicklFuturesClient.GetFuturesRealTimeHandicapsAsync()).FirstOrDefault(x =>
            x.Symbol == symbol
        );
    }

    [McpServerTool]
    [Description("Retrieve futures real-time market data from Klickl.")]
    public async Task<List<FuturesRealTimeHandicapDto>> GetFuturesRealTimeHandicapsAsync()
    {
        return await klicklFuturesClient.GetFuturesRealTimeHandicapsAsync();
    }
}
