namespace WebApiBookService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>()
                .Property(e => e.nombre_autor)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.fecha_nacimiento_autor)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.ciudad_procedencia_autor)
                .IsUnicode(false);

            modelBuilder.Entity<Autor>()
                .Property(e => e.correo_autor)
                .IsUnicode(false);
        }
    }
}
