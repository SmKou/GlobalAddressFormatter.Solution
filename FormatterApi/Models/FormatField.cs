namespace FormatterApi.Models;

public class FormatField
{
    public int FormatFieldId { get; set; }
    public int FormatId { get; set; }
    public Format Format { get; set; }
    public int FieldId { get; set; }
    public Field Field { get; set; }
}