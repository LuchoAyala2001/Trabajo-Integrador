using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Integrador
{
    public class Medico
    {   // Atributos
        private int matricula;
        private string nombre;
        private string apellido;
        private string especialidad;

        // Propiedades 
        public int Matricula { get { return matricula; } set { matricula = value; } }
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public string Apellido { get { return apellido; } set { apellido = value; } }
        public string Especialidad { get { return especialidad; } set { especialidad = value; } }
        // Constructor
        public Medico(int matricula, string nombre, string apellido, string especialidad)
        {
            this.matricula = matricula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
        }
        //Metodo buscar medico por matricula
        public Medico ImprimirMedico()
        {
            Console.WriteLine($"Matrícula: {matricula}, Nombre: {nombre}, Apellido: {apellido}, Especialidad: {especialidad}");
            return this;
        }
    }
}
