using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FormatterClient.Models;

public class Format
{
    /*[JsonIgnore] Attribute to ignore property when object is serialized */
    public string FormatName { get; set; }
    public string FormatPattern { get; set; }
    //public string Description { get; set; }
    public List<FormatField> FormatFields { get; set; }

    public static List<Format> Formats(string countryCode)
    {
        var apiCallTask = ApiHelper.GetFormats(countryCode);
        var result = apiCallTask.Result;
        JArray jsonResponse = JsonConvert.DeserializeObject<JArray>(result);
        List<Format> formats = JsonConvert.DeserializeObject<List<Format>>(jsonResponse.ToString());
        return formats;
    }
    /*    
    private static Dictionary<string, List<Format>> _formats = new Dictionary<string, List<Format>>
    {
        { "AUS", new List<Format>
            {
                new Format
                {
                    FormatName = "GeneralWithStreet",
                    FormatPattern = "{:business}\n{addressee}\n{street-number} {street-name}\n{locality}, {state}, {postal-code}",
                    //Description = "A general format for the country of Australia that takes a street number and street name. The locality, state and postal code are required. Specifying the name of a business is optional. Addressee is the name of the recipient.",
                    FormatFields = new List<string>
                    {
                        "business",
                        "addressee",
                        "street-number",
                        "street-name",
                        "locality",
                        "state",
                        "postal-code"
                    }
                },
                new Format
                {
                    FormatName = "GeneralWithPOBox",
                    FormatPattern = "{:business}\n{addressee}\n{po-box}\n{locality}, {state}, {postal-code}",
                    //Description = "A general format for the country of Australia that takes a PO Box. The locality, state and postal code are required. Specifying the name of a business is optional. Addressee is the name of the recipient.",
                    FormatFields = new List<string>
                    {
                        "business",
                        "addressee",
                        "po-box",
                        "locality",
                        "state",
                        "postal-code"
                    }
                },
                new Format
                {
                    FormatName = "GeneralWithLockedBagNumber",
                    FormatPattern = "{:business}\n{addressee}\n{locked-bag-number}\n{locality}, {state}, {postal-code}",
                    //Description = "A general format for the country of Australia that takes a locked bag number. The locality, state and postal code are required. Specifying the name of a business is optional. Addressee is the name of the recipient.",
                    FormatFields = new List<string>
                    {
                        "business",
                        "addressee",
                        "locked-bag-number",
                        "locality",
                        "state",
                        "postal-code"
                    }
                }
            }
        },
        { "BGD" , new List<Format>
            {
                new Format
                {
                    FormatName = "Urban",
                    FormatPattern = "{addressee}\n{:addressee-details}\n{:unit-number}, {:building-name}\n{street-name} {street-number}\n{town}+{postal-code}\n{country}",
                    //Description = "The urban format for the country of Bangladesh. Addressee details are optional. Country is only needed for mailing internationally. The unit number and name of the building need only be provided if applicable. Otherwise, the name of the addressee, or recipient of the mail or package, the street name and street number, the town, and postal code are required.",
                    FormatFields = new List<string>
                    {
                        "addressee",
                        "addressee-details",
                        "unit-number",
                        "building-name",
                        "street-name",
                        "street-number",
                        "town",
                        "postal-code"
                    }
                },
                new Format
                {
                    FormatName = "Rural",
                    FormatPattern = "{addressee}\n{:addressee-details}\nVillage: {village}\nP.O.:{post-office}\nThana: {thana-name}\n{country}",
                    //Description = "The rural format for the couontry of Bangladesh. Addressee details are optional. Country is only needed for mailing internationally. The name of the addressee, or recipient of the mail or package, the village, post office and thana are required. A thana, meaning police station, is the district of a police station's jurisdiction.",
                    FormatFields = new List<string>
                    {
                        "addressee",
                        "addressee-details",
                        "village",
                        "post-office",
                        "thana-name"
                    }
                }
            }
        }
    };

    public static List<Format> Test_Formats(string country)
    {
        return _formats[country];
    }
    */
}