using Microsoft.EntityFrameworkCore;
namespace ProgettoFinaleBack
{
    public class ProgettoFinaleContext : DbContext
    {
        public DbSet<Mail> Mails { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=ProgettoFinaleBack;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        
    }
}