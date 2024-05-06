
using Microsoft.EntityFrameworkCore;
using GeoMapping.Models;

namespace GeoMapping.Context

{
    public partial class GeoMappingContext : DbContext  
    {
        public GeoMappingContext()
        {
        }

        public GeoMappingContext(DbContextOptions<GeoMappingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
       




        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=Hady-Sharawi\\SQLEXPRESS;Database=GeoMapping;Trusted_Connection=True;TrustServerCertificate=True;MultipleActiveResultSets=true");
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Address>(entity =>
            {
                entity.HasKey(e => e.Id);
            });




            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}




