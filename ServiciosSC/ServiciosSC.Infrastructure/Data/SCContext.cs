using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ServiciosSC.Core.Entities;

namespace ServiciosSC.Infrastructure.Data
{
    public partial class SCContext : DbContext
    {
        public SCContext()
        {
        }

        public SCContext(DbContextOptions<SCContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Credit> Credit { get; set; }
        public virtual DbSet<CreditByClient> CreditByClient { get; set; }
        public virtual DbSet<IdentificationType> IdentificationType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.HasKey(e => e.ClienteId);

                entity.Property(e => e.Apellidos)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CorreoElectronico)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DireccionResidencia)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nombres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.NumeroCelular)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIdentificacion)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ubicacion)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TipoIdentificacion)
                    .WithMany(p => p.Client)
                    .HasForeignKey(d => d.TipoIdentificacionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Client__TipoIden__628FA481");
            });

            modelBuilder.Entity<Credit>(entity =>
            {
                entity.HasKey(e => e.CreditoId);

                entity.Property(e => e.ValorTotalCredito).HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<CreditByClient>(entity =>
            {
                entity.HasKey(e => e.Id);

                entity.HasOne(d => d.Client)
                    .WithMany(p => p.CreditByClient)
                    .HasForeignKey(d => d.ClientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CreditByC__Clien__656C112C");

                entity.HasOne(d => d.Credit)
                    .WithMany(p => p.CreditByClient)
                    .HasForeignKey(d => d.CreditId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CreditByC__Credi__6383C8BA");
            });

            modelBuilder.Entity<IdentificationType>(entity =>
            {
                entity.HasKey(e => e.TipoIdentificacionId);

                entity.Property(e => e.TipoIdentificacionId).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
