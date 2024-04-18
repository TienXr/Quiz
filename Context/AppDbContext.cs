using Microsoft.EntityFrameworkCore;
using Quiz.Model;

namespace Quiz.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Questions> Question { get; set; }

        public DbSet<Quizes> Quiz {  get; set; }
    }
}
