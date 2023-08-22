using Microsoft.EntityFrameworkCore;

namespace FormatterApi.Models;
public class FormatterApiContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Format> Formats { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<FormatField> FormatFields { get; set; }
    public FormatterApiContext(DbContextOptions<FormatterApiContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Country>()
            .HasData(
                new Country { CountryId = 1, CountryCode = "AUS", CountryName = "Australia", Formats = new List<Format>() },
                new Country { CountryId = 2, CountryCode = "BDG", CountryName = "Bangladesh", Formats = new List<Format>() },
                new Country { CountryId = 3, CountryCode = "CHL", CountryName = "Chile", Formats = new List<Format>() },
                new Country { CountryId = 4, CountryCode = "GRC", CountryName = "Greece", Formats = new List<Format>() },
                new Country { CountryId = 5, CountryCode = "IND", CountryName = "India", Formats = new List<Format>() },
                new Country { CountryId = 6, CountryCode = "USA", CountryName = "United States", Formats = new List<Format>() }
            );
    }
}
