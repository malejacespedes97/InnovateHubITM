using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovateHubITM.Shared.Entities
{
    public class Comentario
    {
        public int Id { get; set; }

        [Display(Name = "Contenido")]
        [MaxLength(1000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Contenido { get; set; } = null!;


        [Display(Name = "Fecha")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Fecha { get; set; } = null!;


        //RELACIONAR CURSO_ID
        public Curso Curso { get; set; } = null!; 
        public int CursoId { get; set; }

        //RELACIONAR ESTUDIANTE_ID
        public Estudiante Estudiante { get; set; } = null!;
        public int EstudianteId { get; set; }


    }
}
