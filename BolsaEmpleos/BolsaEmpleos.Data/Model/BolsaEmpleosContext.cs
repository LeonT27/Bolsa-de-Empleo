namespace BolsaEmpleos.Data.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class BolsaEmpleosContext : DbContext
    {
        public BolsaEmpleosContext()
            : base("name=BolsaEmpleos")
        {
        }

        public virtual DbSet<Categoria> Categorias { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Compañia)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Logo)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.URL)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Posicion)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Ubicacion)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Descripcion)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Como_Aplicar)
                .IsUnicode(false);

            modelBuilder.Entity<Job>()
                .Property(e => e.Email)
                .IsUnicode(false);
        }
    }
}
