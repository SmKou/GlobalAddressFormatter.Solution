using System.Text.Json.Serialization;

namespace FormatterApi.Models;

public class Format
{
    [JsonIgnore]
    public int FormatId { get; set; }
    public string FormatName { get; set; }
    public string FormatPattern { get; set; }
    [JsonIgnore]
    public int CountryId { get; set; }
    [JsonIgnore]
    public Country Country { get; set; }
    public List<FormatField> FormatFields { get; set; }
}