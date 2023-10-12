using InnovateHubITM.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace InnovateHubITM.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        //Notación diamante es el nombre de la entidad <>, luego de esto se debe agregar la misma clase en plural
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Inscripcion> Inscripciones { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}