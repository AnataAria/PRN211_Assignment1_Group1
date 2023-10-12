using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using BusinessObjects;
using Microsoft.Extensions.Configuration;

namespace DataAccessObjects
{
    public partial class CarroonManagmentContext : DbContext
    {
        public CarroonManagmentContext()
        {
        }

        public CarroonManagmentContext(DbContextOptions<CarroonManagmentContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cartoon> Cartoons { get; set; }
        public virtual DbSet<CartoonType> CartoonTypes { get; set; }

        private string GetConnectionString()
        {
            IConfiguration configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true).Build();
            return configuration["ConnectionStrings:DefaultConnectionString"];
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
/*#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.*/
                optionsBuilder.UseSqlServer(GetConnectionString());
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cartoon>(entity =>
            {
                entity.ToTable("Cartoon");

                entity.Property(e => e.CartoonId)
                    .HasColumnType("decimal(20, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("cartoonID");

                entity.Property(e => e.Actors)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("actors");

                entity.Property(e => e.CartoonName)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("cartoonName");

                entity.Property(e => e.CartoonType).HasColumnName("cartoonType");

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("country");

                entity.Property(e => e.Director)
                    .IsRequired()
                    .HasMaxLength(120)
                    .HasColumnName("director");

                entity.Property(e => e.LaunchDate)
                    .HasColumnType("date")
                    .HasColumnName("launchDate");

                entity.Property(e => e.ShortDescription)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasColumnName("shortDescription");

                entity.HasOne(d => d.CartoonTypeNavigation)
                    .WithMany(p => p.Cartoons)
                    .HasForeignKey(d => d.CartoonType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CartoonType");
            });

            modelBuilder.Entity<CartoonType>(entity =>
            {
                entity.ToTable("CartoonType");

                entity.Property(e => e.CartoonTypeId).HasColumnName("cartoonTypeID");

                entity.Property(e => e.CartoonName)
                    .HasMaxLength(120)
                    .HasColumnName("cartoonName");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
