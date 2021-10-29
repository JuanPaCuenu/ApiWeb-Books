namespace WebApiBookService.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Autor")]
    public partial class Autor
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_autor { get; set; }

        [Key]
        [StringLength(40)]
        public string nombre_autor { get; set; }

        [Required]
        [StringLength(12)]
        public string fecha_nacimiento_autor { get; set; }

        [Required]
        [StringLength(30)]
        public string ciudad_procedencia_autor { get; set; }

        [Required]
        [StringLength(40)]
        public string correo_autor { get; set; }
    }
}
