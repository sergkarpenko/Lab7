using Microsoft.EntityFrameworkCore;

namespace Lab7_1
{
    public class Context : DbContext
    {
        private static Context? _Instance;

        public DbSet<Animal> Animals { get; set; }
        public DbSet<AnimalClass> AnimalClass { get; set; }
        public DbSet<Eat> Eat { get; set; }
        public DbSet<Biomes> Biomes { get; set; }
        public DbSet<AnimalEat> AnimalEat { get; set; }

        public string DbPath;

        public Context()
        {
            DbPath = @"Data Source = A:\\db.sqlite";
        }

        public static Context GetInstance()
        {
            _Instance ??= new Context();

            return _Instance;
        }



        protected override void OnConfiguring(DbContextOptionsBuilder builder) 
            => builder.UseSqlite(DbPath);


    }
}
