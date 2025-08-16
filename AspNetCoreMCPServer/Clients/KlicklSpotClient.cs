using System.Text.Json;
using AspNetCoreMCPServer.Clients.Models;
using Microsoft.Extensions.Options;

namespace AspNetCoreMCPServer.Clients;

internal class KlicklSpotClient(
    IHttpClientFactory httpClientFactory,
    IOptions<JsonSerializerOptions> options
)
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("KlicklSpot");
    private readonly JsonSerializerOptions _jsonSerializerOptions = options.Value;

    public async Task<SpotMarketRankDto> GetSpotMarketRankAsync()
    {
        var response = await _httpClient.GetFromJsonAsync<KlicklSpotResponse<SpotMarketRankDto>>(
            "/api/idcm/market/Market/GetMarketRank",
            _jsonSerializerOptions
        );

        return response?.Data ?? new SpotMarketRankDto();
    }
}
