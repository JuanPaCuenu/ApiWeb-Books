namespace WebApiBookService.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model2 : DbContext
    {
        public Model2()
            : base("name=Model2")
        {
        }

        public virtual DbSet<Libro> Libro { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Libro>()
                .Property(e => e.titulo_libro)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.num_paginas)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.genero_libro)
                .IsUnicode(false);

            modelBuilder.Entity<Libro>()
                .Property(e => e.autor_libro)
                .IsUnicode(false);
        }
    }
}
