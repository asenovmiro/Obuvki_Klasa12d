using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Obuvki_Klasa.Models;

namespace Obuvki_Klasa.Data;

public class ApplicationDbContext : IdentityDbContext<Client>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }

    public DbSet<Order> Orders { get; set; }

   

    public DbSet<Category> Categories { get; set; }

}
