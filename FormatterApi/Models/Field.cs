namespace FormatterApi.Models;

public class Field
{
    public int FieldId { get; set; }
    public string FieldName { get; set; }
    public List<FormatField> FormatFields { get; set; }
}