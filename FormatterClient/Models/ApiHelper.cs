using RestSharp;

namespace FormatterClient.Models;

public class ApiHelper
{
    public static async Task<string> GetCountries()
    {
        RestClient client = new RestClient("http://localhost:6000/");
        RestRequest request = new RestRequest($"api/countries", Method.Get);
        RestResponse response = await client.GetAsync(request);
        return response.Content;
    }

    public static async Task<string> GetFormats(string country)
    {
        RestClient client = new RestClient("http://localhost:6000/");
        RestRequest request = new RestRequest($"api/formats?country={country}", Method.Get);
        RestResponse response = await client.GetAsync(request);
        return response.Content;
    }
}