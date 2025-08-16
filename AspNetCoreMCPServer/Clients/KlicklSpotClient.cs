namespace AspNetCoreMCPServer.Clients;

internal class KlicklSpotClient
{
    private readonly HttpClient _httpClient;

    public KlicklSpotClient(IHttpClientFactory httpClientFactory)
    {
        _httpClient = httpClientFactory.CreateClient("KlicklSpot");
    }
}
