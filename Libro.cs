using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    public class Libro
    {
        string isbn;
        string titulo;
        Autor autor;
        string editorial;
        int paginas;
        int year;
        bool disponible;
        float precio;
        Ubicacion ubicacion;

        public Libro()
        {
        }

        public Libro(string isbn, string titulo, Autor autor, string editorial, int paginas, int year, bool disponible, float precio)
        {
            this.isbn = isbn;
            this.titulo = titulo;
            this.Autor = autor;
            this.editorial = editorial;
            this.paginas = paginas;
            this.year = year;
            this.disponible = disponible;
            this.precio = precio;
        }

        public string ISBN { get => isbn; set => isbn = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        internal Autor Autor { get => autor; set => autor = value; }
        public string Editorial { get => editorial; set => editorial = value; }
        public int Paginas { get => paginas; set => paginas = value; }
        public int Year { get => year; set => year = value; }
        public bool Disponible { get => disponible; set => disponible = value; }
        public float Precio { get => precio; set => precio = value; }
        internal Ubicacion Ubicacion { get => ubicacion; set => ubicacion = value; }

        public void Mostrardatos()
        {
            Console.WriteLine($"Los datos del libro con isbn: {isbn}");
            Console.WriteLine($"Titulo: {titulo}");
            Console.WriteLine($"Datos del autor:");
            autor.MostrarDatos();
            Console.WriteLine($"Editorial: {editorial}");
        }

        
    }
}
