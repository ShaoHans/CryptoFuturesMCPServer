using System.ComponentModel;
using AspNetCoreMCPServer.Clients;
using AspNetCoreMCPServer.Clients.Models;
using ModelContextProtocol.Server;

namespace AspNetCoreMCPServer.Tools;

internal sealed class KlicklTools(
    KlicklFuturesClient klicklFuturesClient,
    KlicklSpotClient klicklSpotClient
)
{
    [McpServerTool]
    [Description("Retrieve specified futures symbol real-time market data from Klickl.")]
    public async Task<FuturesRealTimeHandicapDto?> GetFuturesRealTimeHandicapAsync(
        IHttpContextAccessor httpContextAccessor,
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

    [McpServerTool]
    [Description("Retrieve spot real-time market rank data from Klickl.")]
    public async Task<SpotMarketRankDto> GetSpotMarketRankAsync()
    {
        return await klicklSpotClient.GetSpotMarketRankAsync();
    }
}
