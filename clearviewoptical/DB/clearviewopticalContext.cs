using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace clearviewoptical.DB
{
    public partial class clearviewopticalContext : DbContext
    {
        public clearviewopticalContext()
        {
        }

        public clearviewopticalContext(DbContextOptions<clearviewopticalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ProductCatMaster> ProductCatMaster { get; set; }
        public virtual DbSet<ProductFeatureLine> ProductFeatureLine { get; set; }
        public virtual DbSet<ProductMaster> ProductMaster { get; set; }
        public virtual DbSet<ProductSubFeatureLine> ProductSubFeatureLine { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
         #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ADMIN-PC\\SQLEXPRESS2008;Database=clearviewoptical;user id=sa; password=Pass@word1");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<ProductCatMaster>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductcatName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProductFeatureLine>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FeatureLine)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductFeatureLine)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductFeatureLine_ProductFeatureLine_ProductID");
            });

            modelBuilder.Entity<ProductMaster>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Image1)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image2)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image3)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image4)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.ProductCatNavigation)
                    .WithMany(p => p.ProductMaster)
                    .HasForeignKey(d => d.ProductCat)
                    .HasConstraintName("FK_ProductMaster_ProductMaster_ProductCatID");
            });

            modelBuilder.Entity<ProductSubFeatureLine>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ProductSubFeature)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductSubFeatureLine)
                    .HasForeignKey(d => d.ProductId)
                    .HasConstraintName("FK_ProductSubFeatureLine_ProductFeatureLine");
            });
        }
    }
}
