namespace WindowsFormsBooks
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBusqueda = new System.Windows.Forms.TextBox();
            this.textTituloLibro = new System.Windows.Forms.TextBox();
            this.textGenerolibro = new System.Windows.Forms.TextBox();
            this.textAnioLibro = new System.Windows.Forms.TextBox();
            this.textPaginasLibro = new System.Windows.Forms.TextBox();
            this.textAutorLibro = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBuscaAutor = new System.Windows.Forms.Button();
            this.btnBuscaTitulo = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnGuardaLibro = new System.Windows.Forms.Button();
            this.btnGuardaAutor = new System.Windows.Forms.Button();
            this.textNombreAutor = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textCiudadAutor = new System.Windows.Forms.TextBox();
            this.dateTimePickFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.textCorreoAutor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBusqueda
            // 
            this.textBusqueda.Location = new System.Drawing.Point(192, 70);
            this.textBusqueda.Name = "textBusqueda";
            this.textBusqueda.Size = new System.Drawing.Size(440, 22);
            this.textBusqueda.TabIndex = 0;
            // 
            // textTituloLibro
            // 
            this.textTituloLibro.Location = new System.Drawing.Point(192, 291);
            this.textTituloLibro.Name = "textTituloLibro";
            this.textTituloLibro.Size = new System.Drawing.Size(560, 22);
            this.textTituloLibro.TabIndex = 1;
            // 
            // textGenerolibro
            // 
            this.textGenerolibro.Location = new System.Drawing.Point(381, 345);
            this.textGenerolibro.Name = "textGenerolibro";
            this.textGenerolibro.Size = new System.Drawing.Size(104, 22);
            this.textGenerolibro.TabIndex = 2;
            // 
            // textAnioLibro
            // 
            this.textAnioLibro.Location = new System.Drawing.Point(192, 345);
            this.textAnioLibro.Name = "textAnioLibro";
            this.textAnioLibro.Size = new System.Drawing.Size(104, 22);
            this.textAnioLibro.TabIndex = 3;
            // 
            // textPaginasLibro
            // 
            this.textPaginasLibro.Location = new System.Drawing.Point(648, 345);
            this.textPaginasLibro.Name = "textPaginasLibro";
            this.textPaginasLibro.Size = new System.Drawing.Size(104, 22);
            this.textPaginasLibro.TabIndex = 4;
            // 
            // textAutorLibro
            // 
            this.textAutorLibro.Location = new System.Drawing.Point(192, 401);
            this.textAutorLibro.Name = "textAutorLibro";
            this.textAutorLibro.Size = new System.Drawing.Size(450, 22);
            this.textAutorLibro.TabIndex = 5;
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(81, 166);
            this.textResultado.Multiline = true;
            this.textResultado.Name = "textResultado";
            this.textResultado.ReadOnly = true;
            this.textResultado.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textResultado.Size = new System.Drawing.Size(664, 71);
            this.textResultado.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buesqueda";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Resultado";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Titulo del Libro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Año Publicación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(510, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Número de páginas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(78, 406);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Autor del Libro";
            // 
            // btnBuscaAutor
            // 
            this.btnBuscaAutor.Location = new System.Drawing.Point(192, 111);
            this.btnBuscaAutor.Name = "btnBuscaAutor";
            this.btnBuscaAutor.Size = new System.Drawing.Size(104, 23);
            this.btnBuscaAutor.TabIndex = 14;
            this.btnBuscaAutor.Text = "Por Autor";
            this.btnBuscaAutor.UseVisualStyleBackColor = true;
            // 
            // btnBuscaTitulo
            // 
            this.btnBuscaTitulo.Location = new System.Drawing.Point(313, 111);
            this.btnBuscaTitulo.Name = "btnBuscaTitulo";
            this.btnBuscaTitulo.Size = new System.Drawing.Size(121, 23);
            this.btnBuscaTitulo.TabIndex = 15;
            this.btnBuscaTitulo.Text = "Por Titulo Libro";
            this.btnBuscaTitulo.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(449, 111);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Por Año de Publicación";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(78, 257);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "Registro de Libros";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(78, 491);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(158, 18);
            this.label9.TabIndex = 18;
            this.label9.Text = "Registro de Autores";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnGuardaLibro
            // 
            this.btnGuardaLibro.Location = new System.Drawing.Point(610, 449);
            this.btnGuardaLibro.Name = "btnGuardaLibro";
            this.btnGuardaLibro.Size = new System.Drawing.Size(135, 23);
            this.btnGuardaLibro.TabIndex = 19;
            this.btnGuardaLibro.Text = "Guardar Libro";
            this.btnGuardaLibro.UseVisualStyleBackColor = true;
            this.btnGuardaLibro.Click += new System.EventHandler(this.btnGuardaLibro_Click);
            // 
            // btnGuardaAutor
            // 
            this.btnGuardaAutor.Location = new System.Drawing.Point(610, 656);
            this.btnGuardaAutor.Name = "btnGuardaAutor";
            this.btnGuardaAutor.Size = new System.Drawing.Size(142, 23);
            this.btnGuardaAutor.TabIndex = 20;
            this.btnGuardaAutor.Text = "Guardar Autor";
            this.btnGuardaAutor.UseVisualStyleBackColor = true;
            this.btnGuardaAutor.Click += new System.EventHandler(this.btnGuardaAutor_Click);
            // 
            // textNombreAutor
            // 
            this.textNombreAutor.Location = new System.Drawing.Point(255, 540);
            this.textNombreAutor.Name = "textNombreAutor";
            this.textNombreAutor.Size = new System.Drawing.Size(450, 22);
            this.textNombreAutor.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(78, 426);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(505, 17);
            this.label10.TabIndex = 22;
            this.label10.Text = "Recuerde que el nombre del Autor debe existir en el sistema para crear el libro";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 545);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 17);
            this.label11.TabIndex = 23;
            this.label11.Text = "Nombre del Autor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(82, 590);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(149, 17);
            this.label12.TabIndex = 24;
            this.label12.Text = "Fecha de Naciemeinto";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(82, 625);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(154, 17);
            this.label13.TabIndex = 25;
            this.label13.Text = "Ciudad de procedencia";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(82, 662);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(125, 17);
            this.label14.TabIndex = 26;
            this.label14.Text = "Correo Electrónico";
            // 
            // textCiudadAutor
            // 
            this.textCiudadAutor.Location = new System.Drawing.Point(255, 625);
            this.textCiudadAutor.Name = "textCiudadAutor";
            this.textCiudadAutor.Size = new System.Drawing.Size(279, 22);
            this.textCiudadAutor.TabIndex = 27;
            // 
            // dateTimePickFechaNacimiento
            // 
            this.dateTimePickFechaNacimiento.Location = new System.Drawing.Point(255, 585);
            this.dateTimePickFechaNacimiento.Name = "dateTimePickFechaNacimiento";
            this.dateTimePickFechaNacimiento.Size = new System.Drawing.Size(279, 22);
            this.dateTimePickFechaNacimiento.TabIndex = 28;
            // 
            // textCorreoAutor
            // 
            this.textCorreoAutor.Location = new System.Drawing.Point(255, 659);
            this.textCorreoAutor.Name = "textCorreoAutor";
            this.textCorreoAutor.Size = new System.Drawing.Size(279, 22);
            this.textCorreoAutor.TabIndex = 29;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 752);
            this.Controls.Add(this.textCorreoAutor);
            this.Controls.Add(this.dateTimePickFechaNacimiento);
            this.Controls.Add(this.textCiudadAutor);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textNombreAutor);
            this.Controls.Add(this.btnGuardaAutor);
            this.Controls.Add(this.btnGuardaLibro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnBuscaTitulo);
            this.Controls.Add(this.btnBuscaAutor);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textAutorLibro);
            this.Controls.Add(this.textPaginasLibro);
            this.Controls.Add(this.textAnioLibro);
            this.Controls.Add(this.textGenerolibro);
            this.Controls.Add(this.textTituloLibro);
            this.Controls.Add(this.textBusqueda);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Books";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBusqueda;
        private System.Windows.Forms.TextBox textTituloLibro;
        private System.Windows.Forms.TextBox textGenerolibro;
        private System.Windows.Forms.TextBox textAnioLibro;
        private System.Windows.Forms.TextBox textPaginasLibro;
        private System.Windows.Forms.TextBox textAutorLibro;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBuscaAutor;
        private System.Windows.Forms.Button btnBuscaTitulo;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnGuardaLibro;
        private System.Windows.Forms.Button btnGuardaAutor;
        private System.Windows.Forms.TextBox textNombreAutor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textCiudadAutor;
        private System.Windows.Forms.DateTimePicker dateTimePickFechaNacimiento;
        private System.Windows.Forms.TextBox textCorreoAutor;
    }
}

