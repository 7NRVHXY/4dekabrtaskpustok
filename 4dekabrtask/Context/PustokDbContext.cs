using _4dekabrtask.Models;
using Microsoft.EntityFrameworkCore;

namespace _4dekabrtask.Context
{
    public class PustokDbContext :DbContext
    {
       public DbSet<Slider> Sliders { get; set; }

        public PustokDbContext(DbContextOptions options) : base(options) { }
    // public DbSet<Slider> Sliders { get; set; }
    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //    {
    //        optionsBuilder.UseSqlServer("Server=DESKTOP-VBJ3NSU\\SQLEXPRESS;Database=PustokDB;Trusted_Connection=true;Integrated Security=True");
    //        base.OnConfiguring(optionsBuilder);
    //    }
    }
}
