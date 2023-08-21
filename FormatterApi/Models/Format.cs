namespace FormatterApi.Models;

public class Format
{
    public int FormatId { get; set; }
    public string FormatName { get; set; }
    public string FormatPattern { get; set; }
    public int CountryId { get; set; }
    public Country Country { get; set; }
}