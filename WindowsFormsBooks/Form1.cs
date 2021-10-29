using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using WindowsFormsBooks.Models;

namespace WindowsFormsBooks
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardaLibro_Click(object sender, EventArgs e)
        {
            string urlPost = "https://localhost:44367/api/Libroes";
            Libro libro = new Libro();
            libro.titulo_libro = textTituloLibro.Text;
            libro.anio_libro =  Int32.Parse(textAnioLibro.Text);
            libro.genero_libro = textGenerolibro.Text;
            libro.num_paginas = textPaginasLibro.Text;
            libro.autor_libro = textAutorLibro.Text;

            string resultado = Send<Libro>(urlPost, libro, "POST");
        }
        private void btnGuardaAutor_Click(object sender, EventArgs e)
        {
            string urlPost = "https://localhost:44367/api/Autors";
            Autor autor = new Autor();
            autor.nombre_autor = textNombreAutor.Text;
            autor.fecha_nacimiento_autor = dateTimePickFechaNacimiento.Text;
            autor.ciudad_procedencia_autor = textCiudadAutor.Text;
            autor.correo_autor = textCorreoAutor.Text;

            string resultado = Send<Autor>(urlPost, autor, "POST");
        }
        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";

            try
            {

                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }
                
                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                    
                }

            }
            catch (Exception e)
            {
                result = e.ToString();

            }
            textResultado.Text = "";
            textResultado.Text = result;
            return result;
        }

        
    }
}
