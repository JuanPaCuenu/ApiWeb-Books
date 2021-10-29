using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApiBookService.Models;

namespace WebApiBookService.Controllers
{
    public class LibroesController : ApiController
    {
        private Model2 db = new Model2();

        // GET: api/Libroes
        public IQueryable<Libro> GetLibro()
        {
            return db.Libro;
        }

        // GET: api/Libroes/5
        [ResponseType(typeof(Libro))]
        public IHttpActionResult GetLibro(int id)
        {
            Libro libro = db.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            return Ok(libro);
        }

        // PUT: api/Libroes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLibro(int id, Libro libro)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != libro.id_libro)
            {
                return BadRequest();
            }

            db.Entry(libro).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LibroExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Libroes
        [ResponseType(typeof(Libro))]
        public IHttpActionResult PostLibro(Libro libro)
        {
            AutorsController au = new AutorsController();
            if (au.AutorExists(libro.autor_libro))
                {
                    if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                db.Libro.Add(libro);
                db.SaveChanges();
            }
            else
            {
                return BadRequest("Error!:El autor no está registrado.");
            }
            return CreatedAtRoute("DefaultApi", new { id = libro.id_libro }, libro);
        }

        // DELETE: api/Libroes/5
        [ResponseType(typeof(Libro))]
        public IHttpActionResult DeleteLibro(int id)
        {
            Libro libro = db.Libro.Find(id);
            if (libro == null)
            {
                return NotFound();
            }

            db.Libro.Remove(libro);
            db.SaveChanges();

            return Ok(libro);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool LibroExists(int id)
        {
            return db.Libro.Count(e => e.id_libro == id) > 0;
        }
    }
}