using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormatterClient.Models;

public class Country
{
    [JsonIgnore]
    public int CountryId { get; set; }
    public string CountryCode { get; set; }
    public string Name { get; set; }

    public static List<Country> GetCountries()
    {
        var apiCallTask = ApiHelper.GetCountries();
        var result = apiCallTask.Result;
        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(jsonResponse.ToString());
        return countries;
    }
}