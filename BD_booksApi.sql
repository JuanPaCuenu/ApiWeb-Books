CREATE TABLE Autor(
	id_autor INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	nombre_autor VARCHAR(40) NOT NULL,
	fecha_nacimiento_autor DATE NOT NULL,
	ciudad_procedencia_autor INTEGER NOT NULL,
	correo_autor INTEGER NOT NULL
);
CREATE TABLE Libro(
	id_libro INTEGER NOT NULL IDENTITY(1,1) PRIMARY KEY,
	titulo_libro VARCHAR(40) NOT NULL,
	anio_libro INTEGER NOT NULL,
	num_paginas VARCHAR(40) NOT NULL,
	genero_libro VARCHAR(40) NOT NULL,
	autor_libro VARCHAR(40) NOT NULL,
	CONSTRAINT autor_lib FOREIGN KEY (autor_libro) REFERENCES Autor(nombre_autor)
);
