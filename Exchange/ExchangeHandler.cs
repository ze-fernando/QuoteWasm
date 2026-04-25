using System.Net.Http.Json;

namespace Price.Exchange;

public class ExchangeHandler(HttpClient client)
{
    private readonly HttpClient _client = client;

    public async Task<QuoteResponse?> GetData()
    {
        return await _client.GetFromJsonAsync<QuoteResponse>(
            "json/last/USD-BRL,EUR-BRL,BTC-BRL"
        );
    }
}