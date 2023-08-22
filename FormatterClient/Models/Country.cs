using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormatterClient.Models;

public class Country
{
    [JsonIgnore]
    public int CountryId { get; set; }
    public string CountryCode { get; set; }
    public string CountryName { get; set; }

    public static List<Country> GetCountries()
    {
        var apiCallTask = ApiHelper.GetCountries();
        var result = apiCallTask.Result;
        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(jsonResponse.ToString());
        return countries;
    }

    public static List<Country> Test_GetCountries()
    {
        List<Country> countries = new List<Country>();
        countries.Add(new Country
        {
            CountryId = 1,
            CountryCode = "BGD",
            CountryName = "Bangladesh"
        });
        return countries;
    }
}