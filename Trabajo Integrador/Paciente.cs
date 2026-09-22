using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Integrador
{
    public class Paciente
    {
        // Atributos
        private string dni;
        private string nombre;
        private string apellido;
        private string telefono;
        // Propiedades
        public string Dni { get { return dni; } set { dni = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Telefono { get { return telefono; } set { telefono = value; } }

        // Constructor
        public Paciente()
        {
        }

    }
}
