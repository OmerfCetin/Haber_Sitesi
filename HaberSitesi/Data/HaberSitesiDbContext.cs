using Entities;
using Microsoft.EntityFrameworkCore;

namespace HaberSitesi.Data
{
    public class HaberSitesiDbContext : DbContext
    {
       public DbSet<Category> Kategoriler {  get; set; }
        public DbSet<Contact> Kontaktlar { get; set; }
        public DbSet<News> Haberler { get; set; }
        public DbSet<Post> Gönderiler { get; set; }
        public DbSet<Slider> Slaytlar { get; set; }
        public DbSet<User> Kullanıcılar { get; set; }

        public HaberSitesiDbContext (DbContextOptions<HaberSitesiDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-CRQ95L2\SQLEXPRESS;Database=DbHaberSitesi;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    CreatedDate = DateTime.Now,
                    IsActive = true,
                    Name = "Admin",
                    Password = "12345",
                    UserName = "Admin",
                    Email = "admin@hotmail.com"
                });
            base.OnModelCreating(modelBuilder);
        }
    }
}
