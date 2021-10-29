using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsBooks.Models
{
    public class Libro
    {
        public int id_libro { get; set; }

        public string titulo_libro { get; set; }

        public int anio_libro { get; set; }

        public string num_paginas { get; set; }

        public string genero_libro { get; set; }

        public string autor_libro { get; set; }
    }
}
