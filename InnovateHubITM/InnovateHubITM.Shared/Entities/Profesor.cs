using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovateHubITM.Shared.Entities
{
    public class Profesor
    {
        public int Id { get; set; }

        [Display(Name = "Nombre")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Apellidos")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Apellidos { get; set; } = null!;

        [Display(Name = "Correo Electronico")]
        [MaxLength(100)]
        [Required(ErrorMessage = "El campo {0} es obligatorio")]
        public string Correo { get; set; } = null!;




    }
}
