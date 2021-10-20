using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    public class Area
    {
        //miembros de clase
        private string id;
        private string descripcion;
        private List<Estante> listaDeEstantes = new List<Estante>();

        //constructores
        public Area()
        {

        }

        public Area(string id, string descripcion)
        {
            this.Id = id;
            this.Descripcion = descripcion;
        }

        public Area(string id)
        {
            this.id = id;
        }

        //propiedades
        public string Id { get => id; set => id = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        //Métodos
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Descripción: {descripcion}");
        }

        public void AgregaEstante(Estante estanteAgregado)
        {
            listaDeEstantes.Add(estanteAgregado);
            Console.WriteLine("Estante agregado con éxito");
        }

    }
}
