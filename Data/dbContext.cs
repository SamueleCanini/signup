using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;


public class dbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=database.db");

    public DbSet<SignUp> Utenti { get ; set; }
    public DbSet<Prodotto> Prodotti {get; set;}

}