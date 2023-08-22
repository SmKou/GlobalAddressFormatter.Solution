namespace FormatterApi.Models;

public class Country
{
    public int CountryId { get; set; }
    public string CountryCode { get; set; }
    public string CountryName { get; set; }
    public List<Format> Formats { get; set; }
}