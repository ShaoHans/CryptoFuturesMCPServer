namespace AspNetCoreMCPServer.Clients.Models;

internal class KlicklFuturesResponse<T>
{
    public bool Success { get; set; }

    public string? Msg { get; set; }

    public int ErrorCode { get; set; }

    public T? Data { get; set; }
}
