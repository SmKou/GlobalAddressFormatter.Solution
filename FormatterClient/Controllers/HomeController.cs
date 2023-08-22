using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using FormatterClient.Models;

namespace FormatterClient.Controllers;

public class HomeController : Controller
{
    [Route("/")]
    public ActionResult Index(string code)
    {
        if (!string.IsNullOrEmpty(code))
        {
            ViewBag.CountryCode = new SelectList(Country.Test_Countries(), "CountryCode", "CountryName", code);
            List<Format> formats = Format.Test_Formats(code);
            Dictionary<string, Format> model = new Dictionary<string, Format>();
            foreach (Format format in formats)
                model.Add(format.FormatName, format);
            return View(model);
        }
        ViewBag.CountryCode = new SelectList(Country.Test_Countries(), "CountryCode", "CountryName");
        return View();
    }

    public ActionResult SelectCountry(string code)
    {
        return RedirectToAction("Index", new { code = code });
    }
}
