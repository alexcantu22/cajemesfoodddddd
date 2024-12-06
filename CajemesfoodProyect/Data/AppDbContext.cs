using Microsoft.EntityFrameworkCore;
using CajemesfoodProyect.Data.Models;

namespace CajemesfoodProyect.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {
            
        }

      

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<platillos_Local>()
                .HasOne(p => p.platillos)
                .WithMany(pl => pl.platillos_Locals)
                .HasForeignKey(pi => pi.platilloId);


            modelBuilder.Entity<platillos_Local>()
                .HasOne(l => l.Local)
                .WithMany(pl => pl.platillos_Locals)
                .HasForeignKey(li => li.LocalId);

            modelBuilder.Entity<Local_proveedor>()
                .HasOne(l => l.localid)
                .WithMany(lp => lp.localProveedors)
                .HasForeignKey(li => li.localId);

            modelBuilder.Entity<Local_proveedor>()
                .HasOne(p => p.proveedor)
                .WithMany(lp => lp.localProveedors)
                .HasForeignKey(pi => pi.proveedorId);

            // Configurar relación uno a muchos entre Local y Administrador
            modelBuilder.Entity<Administrador>()
                .HasOne(a => a.Local)
                .WithMany(l => l.administradors) // Aquí está la propiedad que causaba el problema
                .HasForeignKey(a => a.LocalId);
        




    }

    //Utilizaremos este metodo para obtener y enviar datos a la BD
    public DbSet<platillos> platillos { get; set; }
        public DbSet<Local> local { get; set; }
        public DbSet<platillos_Local> platillos_Locals { get; set; }
        public DbSet<proveedor> proveedors { get; set; }   
        public DbSet<Local_proveedor> localProveedors { get; set; }

        public DbSet<Administrador> administradors { get; set; }

    
    }
}
