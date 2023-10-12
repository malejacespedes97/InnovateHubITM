using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovateHubITM.Shared.Entities
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del estudiante")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El nombre del estudiante es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Apellido del estudiante")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El Apellido del estudiante es obligatorio")]
        public string Apellidos { get; set; } = null!;

        [Display(Name = "Correo del estudiante")]
        [Required(ErrorMessage = "El correo es obligatorio")]
        [DataType(DataType.EmailAddress)]
        public string Correo{ get; set; } = null!;

        public ICollection<Inscripcion> Inscripciones { get; set; } = null!;

    }
}
