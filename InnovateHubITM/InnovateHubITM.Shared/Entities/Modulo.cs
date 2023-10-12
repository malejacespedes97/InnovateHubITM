using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovateHubITM.Shared.Entities
{
    public class Modulo
    {
        public int Id { get; set; }

        [Display(Name = "Titulo")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Titulo { get; set; } = null!;


        [Display(Name = "Contenido")]
        [MaxLength(1000)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Contenido { get; set; } = null!;

        //RELACIONAR CON CURSO_ID
        public Curso Curso { get; set; } = null!;

        public int CursoId { get; set; }




    }
}
