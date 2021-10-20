using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    class Ubicacion
    {
        Area area;
        Estante estante;
        Seccion seccion;
        Libro libro;

        public Ubicacion()
        { }

        public Ubicacion(Area area_, Estante estante_, Seccion seccion_)
        {
            Area = area_;
            Estante = estante_;
            Seccion = seccion_;
        }

        internal Area Area { get => area; set => area = value; }
        internal Estante Estante { get => estante; set => estante = value; }
        internal Seccion Seccion { get => seccion; set => seccion = value; }
        

        public void ShowInfo()
        {
            Console.WriteLine($"Esta es la ubicación del libro {libro.ISBN}");
            Area.ShowInfo();
            Estante.ShowInfo();
            Seccion.ShowInfo();
        }

        public void RecibirLibro(Libro libroRecibido)
        {
            libro = libroRecibido;
        }

    }
}
