using RestSharp;

namespace FormatterClient.Models;

public class ApiHelper
{
    public static async Task<string> GetCountries()
    {
        RestClient client = new RestClient("http://localhost:6000/");
        RestRequest request = new RestRequest($"Countries", Method.Get);
        RestResponse response = await client.GetAsync(request);
        return response.Content;
    }

    public static async Task<string> GetFormats(string countryCode)
    {
        RestClient client = new RestClient("http://localhost:6000/");
        RestRequest request = new RestRequest($"Countries/{countryCode}", Method.Get);
        RestResponse response = await client.GetAsync(request);
        return response.Content;
    }
}