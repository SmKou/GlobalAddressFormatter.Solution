using Microsoft.EntityFrameworkCore;

namespace FormatterApi.Models;
public class FormatterApiContext : DbContext
{
    public DbSet<Country> Countries { get; set; }
    public DbSet<Format> Formats { get; set; }
    public DbSet<Field> Fields { get; set; }
    public DbSet<FormatField> FormatFields { get; set; }
    public FormatterApiContext(DbContextOptions<FormatterApiContext> options) : base(options) { }
}