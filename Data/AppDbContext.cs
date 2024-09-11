using System;
using abstractmaker_api.Models;
using Microsoft.EntityFrameworkCore;

namespace abstractmaker_api.Data;

public class AppDbContext : DbContext
{
    public DbSet<TitleAbstract> TitleAbstracts { get; set; }
    public DbSet<Deed> Deeds { get; set; }
    public DbSet<Mortgage> Mortgages { get; set; }
    public DbSet<Assignments> MortgageAssignments { get; set; }
    public DbSet<Judgment> Judgments { get; set; }
    public DbSet<TaxSheet> TaxSheets { get; set; }
    public DbSet<LegalDescription> LegalDescriptions { get; set; }


    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    { }
}
