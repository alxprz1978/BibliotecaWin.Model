using System;
using System.Collections.Generic;
using System.Text;

namespace BibliotecaWin.Model
{
    public class Autor
    {
        private string idAutor;
        private string nombre;
        private string apPaterno;
        private string apMaterno;
        private string nacionalidad;
        private string email;

        public Autor()
        {
        }

        public Autor(string idAutor, string nombre, string apPaterno, string apMaterno, string nacionalidad, string email)
        {
            this.idAutor = idAutor;
            this.nombre = nombre;
            this.apPaterno = apPaterno;
            this.apMaterno = apMaterno;
            this.nacionalidad = nacionalidad;
            this.email = email;
        }

        public string IdAutor { get => idAutor; set => idAutor = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string ApPaterno { get => apPaterno; set => apPaterno = value; }
        public string ApMaterno { get => apMaterno; set => apMaterno = value; }
        public string Nacionalidad { get => nacionalidad; set => nacionalidad = value; }
        public string Email { get => email; set => email = value; }

        public void MostrarDatos()
        {
            Console.WriteLine($"Id de autor: {idAutor}");
            Console.WriteLine($"Nombre completo: {nombre} {apPaterno} {apMaterno}");
            Console.WriteLine($"Nacionalidad: {nacionalidad}");
            Console.WriteLine($"e-mail: {email}");
        }
    }
}
