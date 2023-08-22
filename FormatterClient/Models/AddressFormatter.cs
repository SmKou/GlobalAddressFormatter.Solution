namespace FormatterClient.Models;

public class AddressFormatter
{
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public List<Format> Formats { get; set; }
}