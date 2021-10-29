using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBooks.Models
{
    public class Autor
    {
        public int id_autor { get; set; }

        public string nombre_autor { get; set; }

        public string fecha_nacimiento_autor { get; set; }

        public string ciudad_procedencia_autor { get; set; }

        public string correo_autor { get; set; }
    }
}
