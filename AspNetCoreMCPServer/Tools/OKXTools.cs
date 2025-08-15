using System.ComponentModel;
using ModelContextProtocol.Server;
using OKX.Api;
using OKX.Api.Common;

namespace AspNetCoreMCPServer.Tools;

internal sealed class OKXTools
{
    private readonly OkxRestApiClient _okxRestApiClient;

    public OKXTools(OkxRestApiClient okxRestApiClient)
    {
        _okxRestApiClient = okxRestApiClient;
    }

    [McpServerTool]
    [Description("Retrieve futures mark price from OKX spot.")]
    public async Task<decimal> GetMarkPriceAsync(
        [Description("The symbol to get the mark price for.")] string symbol
    )
    {
        var result = await _okxRestApiClient.Public.GetMarkPricesAsync(
            OkxInstrumentType.Swap,
            instrumentId: $"{symbol}-SWAP"
        );

        return result.Data?.FirstOrDefault()?.MarkPrice ?? 0.0m;
    }
}
