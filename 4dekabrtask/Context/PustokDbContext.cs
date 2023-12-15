using _4dekabrtask.Models;
using Microsoft.EntityFrameworkCore;

namespace _4dekabrtask.Context
{
    public class PustokDbContext : DbContext
    {


        public PustokDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Setting> Settings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Setting>()
            .HasData(new Setting
            {   Id=1,
                Address = "baku",
                Email = "umbyva@gmail.com",
                Phone = "+994503592382",
                Logo = "/image/logo--footer.png",
            });
        
            base.OnModelCreating(modelBuilder);
        }
        
 


        // public DbSet<Slider> Sliders { get; set; }
        //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //    {
        //        optionsBuilder.UseSqlServer("Server=DESKTOP-VBJ3NSU\\SQLEXPRESS;Database=PustokDB;Trusted_Connection=true;Integrated Security=True");
        //        base.OnConfiguring(optionsBuilder);
        //    }
    }
}
