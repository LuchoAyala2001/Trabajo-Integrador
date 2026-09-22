using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Integrador
{
    public class Espacio
    {   //atributos
        private int nroConsultorio;
        private int piso;
        private string ala;
        private Medico medico;

        //propiedades
        public int NroConsultorio { get { return nroConsultorio; } set {  nroConsultorio = value} }
        public int Piso { get { return piso; } set { piso = value; } }
        public string Ala { get { return ala; } set { ala = value; } }
        public Medico Medico { get { return medico; } set { medico = value; } }

        //constructor
        public Espacio()
        {
        }
    }
}
