using System.Text.Json.Serialization;

namespace FormatterApi.Models;

public class Field
{
    [JsonIgnore]
    public int FieldId { get; set; }
    public string FieldName { get; set; }
    [JsonIgnore]
    public List<FormatField> FormatFields { get; set; }
}