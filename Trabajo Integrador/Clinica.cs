using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Integrador
{
    public class Clinica
    {
        //atributos
        private string nombre;
        private List<Espacio> espacios;
        private List<Medico> medicos;
        private List<Paciente> pacientes;
        //Propiedades
        public string Nombre { get { return nombre; } set { nombre = value; } }
        public List<Espacio> Espacios
        {
            get { return espacios; }
        }

        public List<Medico> Medicos
        {
            get { return medicos; }
        }

        public List<Paciente> Pacientes
        {
            get { return pacientes; }
        }
        //Constructor
        public Clinica(string nombre)
        {
            this.nombre = nombre;
            espacios = new List<Espacio>();
            medicos = new List<Medico>();
            pacientes = new List<Paciente>();
        }
        //metodos Espacio
        public void AgregarEspacio(Espacio espacio)
        {
            espacios.Add(espacio);
        }
        public void EliminarEspacio(Espacio espacio)
        {
            espacios.Remove(espacio);
        }
        public Espacio BuscarConsultorio(int nroConsultorio)
        {
            foreach (var espacio in espacios)
            {
                if (espacio.NroConsultorio == nroConsultorio)
                {
                    return espacio;
                }
            }
            return null;
        }
        //metodos Medico
        public void AgregarMedico(Medico medico)
        {
            medicos.Add(medico);
        }
        public void EliminarMedico(Medico medico)
        {
            medicos.Remove(medico);
        }
        public Medico buscarmedico(int matricula)
        {
            foreach (var medico in medicos)
            {
                if (medico.Matricula == matricula)
                {
                    return medico;
                }
            }
            return null;
        }
        // metodos Paciente
        public void AgregarPaciente(Paciente paciente)
        {
            pacientes.Add(paciente);
        }
        public void EliminarPaciente(Paciente paciente)
        {
            pacientes.Remove(paciente);
        }
        public Paciente BuscarPaciente(string dni)
        {
            foreach (var paciente in pacientes)
            {
                if (paciente.Dni == dni)
                {
                    return paciente;
                }
            }
            return null;
        }

    }
}
