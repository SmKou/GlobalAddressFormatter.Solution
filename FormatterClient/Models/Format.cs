using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormatterClient.Models;

public class Format
{
    [JsonIgnore]
    public int FormatId { get; set; }
    [JsonIgnore]
    public int CountryId { get; set; }
    public string FormatName { get; set; }
    public string Pattern { get; set; }
    public string Description { get; set; }
    public List<string> Fields { get; set; }

    public static List<Format> GetFormats(string country)
    {
        var apiCallTask = ApiHelper.GetFormats(country);
        var result = apiCallTask.Result;
        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Format> formats = JsonConvert.DeserializeObject<List<Format>>(jsonResponse.ToString());
        return formats;
    }

    public static List<Format> Test_GetFormats(string country)
    {
        Dictionary<string, Format[]> formats = new Dictionary<string, Format[]>();
        formats.Add("GGD", new Format[]
        {
            new Format
            {
                FormatName = "",
                Pattern = "",
                Description = "",
                Fields = new List<string>
                {
                    ""
                }
            }
        });

        if (formats[country] == null)
        {
            ModelState.AddModelError("Country", "Country not supported.")
            return View(ModelState);
        }
        return formats;
    }
}