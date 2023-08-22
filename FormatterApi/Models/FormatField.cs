using System.Text.Json.Serialization;

namespace FormatterApi.Models;

public class FormatField
{
    [JsonIgnore]
    public int FormatFieldId { get; set; }
    [JsonIgnore]
    public int FormatId { get; set; }
    [JsonIgnore]
    public Format Format { get; set; }
    [JsonIgnore]
    public int FieldId { get; set; }
    public Field Field { get; set; }
}