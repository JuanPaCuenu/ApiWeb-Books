namespace WebApiBookService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Libro")]
    public partial class Libro
    {
        [Key]
        public int id_libro { get; set; }

        [Required]
        [StringLength(40)]
        public string titulo_libro { get; set; }

        public int anio_libro { get; set; }

        [Required]
        [StringLength(40)]
        public string num_paginas { get; set; }

        [Required]
        [StringLength(40)]
        public string genero_libro { get; set; }

        [Required]
        [StringLength(40)]
        public string autor_libro { get; set; }
    }
}
