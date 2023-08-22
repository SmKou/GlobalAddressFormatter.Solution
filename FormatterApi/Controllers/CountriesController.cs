using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FormatterApi.Models;

namespace FormatterApi.Controllers;

[ApiController]
[Route("[controller]")]
public class CountriesController : ControllerBase
{
    private readonly ILogger<CountriesController> _logger;
    private readonly FormatterApiContext _db;

    public CountriesController(ILogger<CountriesController> logger, FormatterApiContext db)
    {
        _logger = logger;
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Country>>> Get()
    {
        return await _db.Countries.ToListAsync();
    }

    [HttpGet("{countryCode}")]
    public async Task<ActionResult<Country>> GetCountryFormat(string countryCode)
    {
        Country country = await _db.Countries
            .Include(m => m.Formats)
            .ThenInclude(m => m.FormatFields)
            .ThenInclude(m => m.Field)
            .FirstOrDefaultAsync(m => m.CountryCode == countryCode);
        if (country == null)
        {
            return NotFound();
        }
        return country;
    }
}
