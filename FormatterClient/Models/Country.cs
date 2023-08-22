using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormatterClient.Models;

public class Country
{
    public string CountryCode { get; set; }
    public string CountryName { get; set; }

    public static List<Country> Countries()
    {
        var apiCallTask = ApiHelper.GetCountries();
        var result = apiCallTask.Result;
        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(jsonResponse.ToString());
        return countries;
    }

    private static List<Country> _countries = new List<Country>
    {
        new Country
        {
            CountryCode = "BGD",
            CountryName = "Bangladesh"
        },
        new Country
        {
            CountryCode = "AUS",
            CountryName = "Australia"
        }
    };

    public static List<Country> Test_Countries()
    {
        return _countries;
    }
}