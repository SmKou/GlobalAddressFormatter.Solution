namespace FormatterClient.Models;

public class AddressFormatter
{
    public string CountryCode { get; set; }
    public Dictionary<string, Format> Formats { get; set; }
    public string Pattern { get; set; }
    public Dictionary<string, string> Fields { get; set; }
}