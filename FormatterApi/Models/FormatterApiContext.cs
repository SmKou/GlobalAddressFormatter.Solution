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
                new Country { CountryId = 1, CountryCode = "AUS", CountryName = "Australia"},
                new Country { CountryId = 2, CountryCode = "BDG", CountryName = "Bangladesh"},
                new Country { CountryId = 3, CountryCode = "CHL", CountryName = "Chile"},
                new Country { CountryId = 4, CountryCode = "GRC", CountryName = "Greece"},
                new Country { CountryId = 5, CountryCode = "IND", CountryName = "India" },
                new Country { CountryId = 6, CountryCode = "USA", CountryName = "United States" }
            );

        builder.Entity<Format>()
            .HasData(
                new Format { FormatId = 1, FormatName = "Australia (general, to street address)", FormatPattern = "{:business}\n{addressee}\n{street-number} {street-name}\n{locality}, {state}, {postal-code}", CountryId = 1 },
                new Format { FormatId = 2, FormatName = "Australia (general, to PO Box)", FormatPattern = "{:business}\n{addressee}\n{po-box}\n{locality}, {state}, {postal-code}", CountryId = 1 },
                new Format { FormatId = 3, FormatName = "Australia (general, to Locked Bag)", FormatPattern = "{:business}\n{addressee}\n{locked-bag-number}\n{locality}, {state}, {postal-code}", CountryId = 1 },
                new Format { FormatId = 4, FormatName = "Bangladesh (urban)", FormatPattern = "{addressee}\n{:additional-details}\n{unit}, {building}\n{street-name} {street-number}\n{town}+{postal-code}\n{country}", CountryId = 2 },
                new Format { FormatId = 5, FormatName = "Bangladesh (rural)", FormatPattern = "{addressee}\n{:additional-details}\nVillage: {village}\nP.O.:{post-office}\nThana: {thana-name}\n{country}", CountryId = 2 },
                new Format { FormatId = 6, FormatName = "Chile (multiple municipality city, with unit/apartment number)", FormatPattern = "{addressee}\n{street-name} {number}, {unit}\n{:postal-code} {municipality}\n{region}", CountryId = 3 },
                new Format { FormatId = 7, FormatName = "Chile (multiple municipality city, no unit/apartment number)", FormatPattern = "{addressee}\n{street-name} {number}\n{:postal-code} {municipality}\n{region}", CountryId = 3 },
                new Format { FormatId = 8, FormatName = "Chile (single municipality city, with unit/apartment number)", FormatPattern = "{addressee}\n{street-name} {number}, {unit}\n{neighborhood}\n{region}", CountryId = 3 },
                new Format { FormatId = 9, FormatName = "Chile (single municipality city, no unit/apartment number)", FormatPattern = "{addressee}\n{street-name} {number}\n{neighborhood}\n{region}", CountryId = 3 },
                new Format { FormatId = 10, FormatName = "Chile (rural, with unit/apartment number)", FormatPattern = "{addressee}\n{street-name} {number}, {unit}\n{postal-code} {town}\n{region}", CountryId = 3 },
                new Format { FormatId = 11, FormatName = "Chile (rural, no unit/apartment number)", FormatPattern = "{addressee}\n{street-name} {number}\n{postal-code} {town}\n{region}", CountryId = 3 },
                new Format { FormatId = 12, FormatName = "Chile (rural, no individual house numbers)", FormatPattern = "{addressee}\n{street-name}, {additional-information}\n{postal-code} {town}\n{region}", CountryId = 3 },
                new Format { FormatId = 13, FormatName = "Greece (non-international mail)", FormatPattern = "{addressee}\n{street-address}\n{postal-code}, {town}", CountryId = 4 },
                new Format { FormatId = 14, FormatName = "Greece (international mail)", FormatPattern = "{addressee}\n{street-address}\n{countrycode} {postal-code}, {town}", CountryId = 4 },
                new Format { FormatId = 15, FormatName = "India (general, international)", FormatPattern = "{addressee} {relation} of {relation-name}\n{door-number} {street-number}, {street-name}\nvia {via-name}\n{post-name}\n{taluk-name}\n{locality}\n{city} - {postal-code}\n{district}\n{state}\n{country}", CountryId = 5 },
                new Format { FormatId = 16, FormatName = "India (rural)", FormatPattern = "{addressee}\n{street-number}, {street-name}\n{village}\n{district}\n{postal-code}\n{state}", CountryId = 5 },
                new Format { FormatId = 17, FormatName = "India (urban)", FormatPattern = "{addressee}\n{:occupation}\n{unit}, {building}\n{street-number}, {street-name}\n{locality}\n{postal-code}\n{state}", CountryId = 5 },
                new Format { FormatId = 18, FormatName = "USA (general)", FormatPattern = "{addressee}\n{house-number}, {street-name}, {unit}\n{city}, {state} {zipcode}", CountryId = 6 }
            );

        builder.Entity<Field>()
            .HasData(
                new Field { FieldId = 1, FieldName = "business" },
                new Field { FieldId = 2, FieldName = "addressee" },
                new Field { FieldId = 3, FieldName = "street-number" },
                new Field { FieldId = 4, FieldName = "street-name" },
                new Field { FieldId = 5, FieldName = "locality" },
                new Field { FieldId = 6, FieldName = "state" },
                new Field { FieldId = 7, FieldName = "postal-code" },
                new Field { FieldId = 8, FieldName = "po-box" },
                new Field { FieldId = 9, FieldName = "locked-bag-number" },
                new Field { FieldId = 10, FieldName = "additional-details" },
                new Field { FieldId = 11, FieldName = "unit" },
                new Field { FieldId = 12, FieldName = "building" },
                new Field { FieldId = 13, FieldName = "town" },
                new Field { FieldId = 14, FieldName = "country" },
                new Field { FieldId = 15, FieldName = "village" },
                new Field { FieldId = 16, FieldName = "post-office" },
                new Field { FieldId = 17, FieldName = "thana-name" },
                new Field { FieldId = 18, FieldName = "number" },
                new Field { FieldId = 19, FieldName = "municipality" },
                new Field { FieldId = 20, FieldName = "region" },
                new Field { FieldId = 21, FieldName = "neighborhood" },
                new Field { FieldId = 22, FieldName = "additional-information" },
                new Field { FieldId = 23, FieldName = "countrycode" },
                new Field { FieldId = 24, FieldName = "relation" },
                new Field { FieldId = 25, FieldName = "relation-name" },
                new Field { FieldId = 26, FieldName = "door-number" },
                new Field { FieldId = 27, FieldName = "via-name" },
                new Field { FieldId = 28, FieldName = "post-name" },
                new Field { FieldId = 29, FieldName = "taluk-name" },
                new Field { FieldId = 30, FieldName = "city" },
                new Field { FieldId = 31, FieldName = "district" },
                new Field { FieldId = 32, FieldName = "state" },
                new Field { FieldId = 33, FieldName = "occupation" },
                new Field { FieldId = 34, FieldName = "house-number" },
                new Field { FieldId = 35, FieldName = "zipcode" }
            );
    }
}
