using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormatterClient.Models;

public class Format
{
    [JsonIgnore]
    public int FormatId { get; set; }
    public string Name { get; set; }
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
}