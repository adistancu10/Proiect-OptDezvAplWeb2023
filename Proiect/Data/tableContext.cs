using Microsoft.EntityFrameworkCore;
using Proiect.Models;

namespace Proiect.Data
{

    public class tableContext : DbContext
    {
        public tableContext() { }
        public DbSet<Elev> Elevi { get; set; }
        public DbSet<Clasa> Clase { get; set; }
        public DbSet<Diriginte> Diriginti { get; set; }
        public DbSet<Profesor> Profesori { get; set; }
        public DbSet<Materie> Materii { get; set; }
        public DbSet<ElevMaterie> EleviMaterii { get; set; }

        public DbSet<User> Users { get; set; }

        public tableContext(DbContextOptions<tableContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //one-to-one clasa-diriginte:

            modelBuilder.Entity<Clasa>()
                   .HasOne(cl => cl.Diriginte)
                   .WithOne(dir => dir.Clasa)
                   .HasForeignKey<Diriginte>(dir => dir.ClasaId);

            //one-to-many Elev-Clasa

            modelBuilder.Entity<Clasa>()
                .HasMany(cl => cl.Elevi)
                .WithOne(e => e.Clasa)
                .HasForeignKey(e=> e.ClasaId);

            
            base.OnModelCreating(modelBuilder);

            //one-to-many Elev-Profesor

            modelBuilder.Entity<Profesor>()
                .HasMany(p => p.Elevi)
                .WithOne(e => e.Profesor)
                .HasForeignKey(e => e.ProfesorId);

            //many-to-many  Elev-Materie

            modelBuilder.Entity<ElevMaterie>().HasKey(elmat => new { elmat.ElevId, elmat.MaterieId });

            //one-to-many for many-to-many
            modelBuilder.Entity<ElevMaterie>()
                    .HasOne(elmat => elmat.Elev)
                    .WithMany(m => m.ElevMaterie)
                    .HasForeignKey(elmat => elmat.ElevId);

            modelBuilder.Entity<ElevMaterie>()
                   .HasOne(elmat => elmat.Materie)
                   .WithMany(e => e.ElevMaterie)
                   .HasForeignKey(elmat => elmat.MaterieId);

            base.OnModelCreating(modelBuilder);
        }

    }
}
