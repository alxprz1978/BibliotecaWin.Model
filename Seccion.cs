using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    public class Seccion
    {
        private string id;
        private string descripcion;
        private List<Libro> listadoDeLibros = new List<Libro>();

        public Seccion()
        {
        }

        public Seccion(string id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        

        public void ShowInfo()
        {
            Console.WriteLine($"ID Sección: {id}");
            Console.WriteLine($"Descripción: {descripcion}");
            Console.WriteLine($"Número de libros: {listadoDeLibros.Count}");
        }

        public void AgregarLibro(Libro libroQueSeVaAgregar)
        {
            listadoDeLibros.Add(libroQueSeVaAgregar);
            Console.WriteLine("El libro fue agregado con éxito");
        }
    }
}
