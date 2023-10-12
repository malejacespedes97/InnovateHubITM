using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovateHubITM.Shared.Entities
{
    public class Curso
    {
        public int Id { get; set; }

        [Display(Name = "Nombre del curso")]
        [MaxLength(50)]
        [Required(ErrorMessage = "El nombre del curso es obligatorio")]
        public string Nombre { get; set; } = null!;

        [Display(Name = "Descripción del curso")]
        [MaxLength(100)]
        [Required(ErrorMessage = "La descripción del curso es obligatoria")]
        public string Descripcion { get; set; } = null!;

        [Display(Name = "Duración del curso")]
        [MaxLength(50)]
        [Required(ErrorMessage = "La duración del curso es obligatoria")]
        public string Duracion { get; set; } = null!;

        [Display(Name = "Precio del curso")]
        [MaxLength(20)]
        [Required(ErrorMessage = "El precio del curso es obligatoria")]
        public string Precio { get; set; } = null!;

        public ICollection<Inscripcion> Inscripciones { get; set; } = null!;

    }
}
