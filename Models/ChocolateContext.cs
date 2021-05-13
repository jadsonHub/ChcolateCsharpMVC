using Microsoft.EntityFrameworkCore;

namespace ProjetoChocolate.Models
{
    public class ChocolateContext : DbContext
    {
        public  ChocolateContext(DbContextOptions<ChocolateContext> options) : base(options)
       {

       }
       public DbSet<Chocolate> Chocolates {get; set; }
    }
}