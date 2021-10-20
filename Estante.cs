using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    public class Estante
    {
        //miembros de la clase
        private string id;
        private string descripcion;
        private List<Seccion> listaDeSecciones = new List<Seccion>();
            
        //constructores
        public Estante()
        {
        }

        public Estante(string id, string descripcion)
        {
            this.id = id;
            this.descripcion = descripcion;
        }

        //propiedades
        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        

        //métodos
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Descripción: {descripcion}");
        }

        public void AgregarSeccion(Seccion seccionAgregada)
        {
            listaDeSecciones.Add(seccionAgregada);
            Console.WriteLine("La sección fue agregada con éxito");
        }

    }
}
