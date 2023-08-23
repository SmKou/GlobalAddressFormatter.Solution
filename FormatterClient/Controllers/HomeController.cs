using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FormatterClient.Models;

namespace FormatterClient.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public ActionResult Index()
    {
        List<Country> countries = Country.Test_Countries();
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

    [Route("/details")]
    public ActionResult Details(Country country)
    {
        if (country == null || country.CountryCode == "")
            return RedirectToAction("Index");
        AddressFormatter model = new AddressFormatter();
        model.CountryCode = country.CountryCode;
        List<Country> countries = Country.Test_Countries();
        for (int i = 0; i < countries.Count; i++)
            if (countries[i].CountryCode == country.CountryCode)
                model.CountryName = countries[i].CountryName;
        model.Formats = Format.Test_Formats(country.CountryCode);
        return View(model);
    }
}
