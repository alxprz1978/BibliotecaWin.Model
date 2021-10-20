using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    class AdmonBiblioteca
    {
        string nombre;
        string direccion;
        string administrador;

        List<Lector> lectoresRegistrados = new List<Lector>();
        List<Lector> lectoresEnListaNegra = new List<Lector>();

        public AdmonBiblioteca()
        {
        }

        public AdmonBiblioteca(string nombre, string direccion, string administrador)
        {
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Administrador = administrador;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Administrador { get => administrador; set => administrador = value; }

        public void AgregaRegistrado(Lector lectorRegistrado)
        {
            lectoresRegistrados.Add(lectorRegistrado);
        }

        public void AgregaAListaNegra(Lector lectorSancionado)
        {
            lectoresEnListaNegra.Add(lectorSancionado);
        }

        public void ImprimeRegistrados()
        {
            foreach(Lector lectorX in lectoresRegistrados)
            {
                lectorX.ShowInfo();
            }
        }


    }
}
