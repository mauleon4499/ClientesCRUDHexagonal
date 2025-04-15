using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Persistence
{
    public class AppDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Articulo> Articulos { get; set; }
        public DbSet<Almacen> Almacenes { get; set; }
        public DbSet<Ubicacion> Ubicaciones { get; set; }
        public DbSet<Inventario> Inventarios { get; set; }
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configuración de la entidad Cliente  
            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.ToTable("Clientes");
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Nombre).IsRequired().HasMaxLength(100);
                entity.Property(c => c.Email).IsRequired().HasMaxLength(100);
                entity.Property(c => c.IdDireccion).IsRequired().HasColumnName("ID_DIRECCION");
            });
            modelBuilder.Entity<Cliente>()
                .HasOne(c => c.Direccion)
                .WithMany(d => d.Clientes)
                .HasForeignKey(c => c.IdDireccion)
                .IsRequired();

            // Configuración de la entidad Direccion
            modelBuilder.Entity<Direccion>().ToTable("Direccion");
            modelBuilder.Entity<Direccion>().HasKey(d => d.Id);
            modelBuilder.Entity<Direccion>().Property(d => d.Calle).IsRequired().HasMaxLength(100);

        }
    }
}
