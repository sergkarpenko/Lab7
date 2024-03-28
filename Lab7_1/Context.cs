using Microsoft.EntityFrameworkCore;

namespace Lab7_1
{
    public class Context : DbContext
    {
        private static readonly Context _Instance = new();
        public static Context Instance => _Instance;
        private Context() { }

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Klass> Klasses { get; set; }
        public DbSet<Eat> Eats { get; set; }
        public DbSet<Biome> Biomes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
            => builder.UseSqlite(@"Data Source = F:\\db.sqlite");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animal>()
                .HasMany(e => e.Eats)
                .WithMany(e => e.Animals);

            modelBuilder.Entity<Animal>().Navigation(e => e.Eats).AutoInclude();
        }

    }
}
