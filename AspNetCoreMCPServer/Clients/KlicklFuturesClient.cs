using System.Text.Json;
using AspNetCoreMCPServer.Clients.Models;
using Microsoft.Extensions.Options;

namespace AspNetCoreMCPServer.Clients;

internal class KlicklFuturesClient(
    IHttpClientFactory httpClientFactory,
    IOptions<JsonSerializerOptions> options
)
{
    private readonly HttpClient _httpClient = httpClientFactory.CreateClient("KlicklFutures");
    private readonly JsonSerializerOptions _jsonSerializerOptions = options.Value;

    public async Task<List<FuturesRealTimeHandicapDto>> GetFuturesRealTimeHandicapsAsync()
    {
        var response = await _httpClient.PostAsync("/api/market/RealTimeHandicapFull", null);
        response.EnsureSuccessStatusCode();

        var content = await response.Content.ReadAsStringAsync();
        return JsonSerializer
                .Deserialize<KlicklFuturesResponse<List<FuturesRealTimeHandicapDto>>>(
                    content,
                    _jsonSerializerOptions
                )
                ?.Data ?? [];
    }
}
