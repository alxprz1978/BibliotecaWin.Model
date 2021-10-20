using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    class Lector
    {
        string id;
        string nombre;
        string apPaterno;
        string apMaterno;
        List<Libro> libros = new List<Libro>();

        public Lector()
        {
        }

        public Lector(string id, string nombre, string apPaterno, string apMaterno)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.ApPaterno = apPaterno;
            this.ApMaterno = apMaterno;
            
        }

        public string Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }

        public void AgregaLibro(Libro libroPrestado)
        {
            libros.Add(libroPrestado);
        }

        public void QuitarLibro(Libro libroPrestado)
        {
            libros.Remove(libroPrestado);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Nombre Completo: {nombre} {apPaterno} {apMaterno}");
            Console.WriteLine();
        }

    }
}
