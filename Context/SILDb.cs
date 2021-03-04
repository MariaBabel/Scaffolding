using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Scaffolding.Entities;

#nullable disable

namespace SIL.DbContext
{
    public partial class SILDb : DbContext
    {
        public SILDb()
        {
        }

        public SILDb(DbContextOptions<SILDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Buque> Buques { get; set; }
        public virtual DbSet<Sigma> Sigmas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=JALDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Buque>(entity =>
            {
                entity.Property(e => e.Denominacion)
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("('0001-01-01T00:00:00.0000000+00:00')");

                entity.Property(e => e.MarCos)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.TipoBi)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("TipoBI")
                    .IsFixedLength(true);

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(100);
            });

            modelBuilder.Entity<Sigma>(entity =>
            {
                entity.HasIndex(e => e.BuqueId, "IX_Sigmas_BuqueId");

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("('0001-01-01T00:00:00.0000000+00:00')");

                entity.Property(e => e.Nsigma)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .HasColumnName("NSigma")
                    .IsFixedLength(true);

                entity.Property(e => e.TipoDocSigma)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength(true);

                entity.Property(e => e.Tipomate)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Titude)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Titupara)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UsuarioCreacion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.UsuarioModificacion).HasMaxLength(100);

                entity.HasOne(d => d.Buque)
                    .WithMany(p => p.Sigmas)
                    .HasForeignKey(d => d.BuqueId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
