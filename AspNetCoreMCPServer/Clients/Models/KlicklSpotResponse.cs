namespace AspNetCoreMCPServer.Clients.Models;

internal class KlicklSpotResponse<T>
{
    public bool NeedLang { get; set; } = true;

    public bool Status { get; set; }

    public string? Msg { get; set; }

    public string? Url { get; set; }

    public string? StatusCode { get; set; }

    public object? Extra { get; set; }

    public T? Data { get; set; }
}
