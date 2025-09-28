using Microsoft.EntityFrameworkCore;
using EquipoDeExamenProgra.Models;

namespace EquipoDeExamenProgra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Habit> Habits { get; set; }
    }
}