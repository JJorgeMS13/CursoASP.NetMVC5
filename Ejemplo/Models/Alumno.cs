namespace Ejemplo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;
    using System.Data.Entity;

    [Table("Alumno")]
    public partial class Alumno
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required]
        [StringLength(100)]
        public string Apellido { get; set; }

        public int Sexo { get; set; }

        [StringLength(10)]
        public string FechaNacimiento { get; set; }

        public List<Alumno> Listar()
        {
            var alumnos = new List<Alumno>();
            try
            {
                using (var  ctx = new TestContex())
                {
                    alumnos = ctx.Alumno.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return alumnos;
        }

        public void Guardar( Alumno alumno)
        {
            try
            {
                using (var ctx = new TestContex())
                {
                    //Regitro que ya existe
                    if (alumno.Id > 0)
                    {
                        ctx.Entry(alumno).State = EntityState.Modified;
                    }
                    else
                    {
                        ctx.Entry(alumno).State = EntityState.Added;
                    }
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Eliminar(int id)
        {
            try
            {
                using (var ctx = new TestContex())
                {
                    ctx.Entry(new Alumno { Id = id }).State = EntityState.Deleted;
                    ctx.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Alumno Obtener(int id)
        {
            var alumnos = new Alumno();
            try
            {
                using (var ctx = new TestContex())
                {
                    alumnos = ctx.Alumno.Where(x => x.Id == id).SingleOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return alumnos;
        }

    }
}
