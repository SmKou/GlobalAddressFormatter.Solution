using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FormatterClient.Models;

namespace FormatterClient.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public ActionResult Index()
    {
        List<Country> countries = Country.Countries();
        List<SelectListItem> list = new List<SelectListItem>();
        list.Add(new SelectListItem()
        {
            Text = "Select a country",
            Value = ""
        });
        foreach (Country country in countries)
            list.Add(new SelectListItem()
            {
                Text = country.CountryName,
                Value = country.CountryCode
            });
        ViewBag.CountryCode = new SelectList(list, "Value", "Text");
        return View();
    }

    [Route("/Details/")]
    public ActionResult Details(Country country)
    {
        if (country == null || country.CountryCode == "")
            return RedirectToAction("Index");
        AddressFormatter model = new AddressFormatter();
        model.CountryCode = country.CountryCode;
        List<Country> countries = Country.Countries();
        for (int i = 0; i < countries.Count; i++)
            if (countries[i].CountryCode == country.CountryCode)
                model.CountryName = countries[i].CountryName;
        model.Formats = Format.Formats(country.CountryCode);
        Console.WriteLine("###################################");
        Console.WriteLine(model.Formats[0].FormatFields[0].Field.FieldName);
        return View(model);
    }
}
