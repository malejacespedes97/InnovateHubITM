using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovateHubITM.Shared.Entities
{
    public class Inscripcion
    {

        public int Id { get; set; }

        [Display(Name = "Fecha")]
        public string Fecha { get; set; } = null!;
        public Curso Curso { get; set; } = null!;
        public int CursoId { get; set; }
        public Estudiante Estudiante { get; set; } = null!;
        public int EstudianteID { get; set; }

    }
}
