using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnovateHubITM.Shared.Entities
{
    public class Curso
    {
        public ICollection<Comentario> Comentarios { get; set; } = null!;

        public ICollection<Modulo> Modulos { get; set; } = null!;
    }
}
