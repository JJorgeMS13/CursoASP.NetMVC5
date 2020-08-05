namespace Ejemplo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class TestContex : DbContext
    {
        public TestContex()
            : base("name=TestContex")
        {
        }

        public virtual DbSet<Alumno> Alumno { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Apellido)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.FechaNacimiento)
                .IsUnicode(false);
        }
    }
}
