using System.Text.Json;
using AspNetCoreMCPServer.Clients.Models;
using Microsoft.Extensions.Options;

namespace AspNetCoreMCPServer.Clients;

internal class KlicklFuturesClient
{
    private readonly HttpClient _httpClient;
    private readonly JsonSerializerOptions _jsonSerializerOptions;

    public KlicklFuturesClient(
        IHttpClientFactory httpClientFactory,
        IOptions<JsonSerializerOptions> options
    )
    {
        _httpClient = httpClientFactory.CreateClient("KlicklFutures");
        _jsonSerializerOptions = options.Value;
    }

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
