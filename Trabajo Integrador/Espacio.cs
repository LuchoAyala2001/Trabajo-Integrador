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
        public int NroConsultorio { get { return nroConsultorio; } set { nroConsultorio = value; } }
        public int Piso { get { return piso; } set { piso = value; } }
        public string Ala { get { return ala; } set { ala = value; } }
        public Medico Medico { get { return medico; } set { medico = value; } }

        //constructor
        public Espacio(int nroConsultorio, int piso, string ala, Medico medico)
        {
            this.nroConsultorio = nroConsultorio;
            this.piso = piso;
            this.ala = ala;
            this.medico = medico;
        }
        //metodos
        public virtual Espacio imprimirEspacio()
        {
            Console.WriteLine($"Consultorio Nro: {nroConsultorio}, Piso: {piso}, Ala: {ala}, Medico: {medico.Nombre} {medico.Apellido}, Especialidad del Medico: {medico.Especialidad}");
            return this;
        }


    }
                                                                        //HERENCIA



                                                                        //Consultorio General
    public class ConsultorioGeneral: Espacio
    {
        //atributos 
        private bool receta;
        //Propiedades
        public bool Receta { get { return receta; } set { receta = value; } }
        //Constructor
        public ConsultorioGeneral(int nroConsultorio, int piso, string ala, Medico medico, bool receta) : base(nroConsultorio, piso, ala, medico)
        {
            this.receta = receta;
        }
        public override Espacio imprimirEspacio()
        {
            Console.WriteLine($" Consultorio General: Consultorio Nro: {NroConsultorio}, Piso: {Piso}, Ala: {Ala}, Medico: {Medico.Nombre} {Medico.Apellido}, Especialidad: {Medico.Especialidad}, Receta: {receta}");
            return this;
        }
    }
    //Consultorio Especializado
    public class ConsultorioEspecializado : Espacio
    {
        //atributos
        private string especialidad;
        private List<HorarioAtencion> horariosAtencion;
        //Propiedades
        public string Especialidad { get { return especialidad; } set { especialidad = value; } }
        public List<HorarioAtencion> HorariosAtencion { get { return horariosAtencion; } set { horariosAtencion = value; } }
        //Constructor
        public ConsultorioEspecializado(int nroConsultorio, int piso, string ala, Medico medico, string especialidad, List<HorarioAtencion> horariosAtencion) : base(nroConsultorio, piso, ala, medico)
        {
            this.especialidad = especialidad;
            this.horariosAtencion = horariosAtencion;
        }
        //Metodo
        public override Espacio imprimirEspacio()
        {
            Console.WriteLine($" Consultorio Especializado: Consultorio Nro: {NroConsultorio}, Piso: {Piso}, Ala: {Ala}, Medico: {Medico.Nombre} {Medico.Apellido}, Especialidad: {especialidad}");
            return this;
        }
    }
                                                            // Salas de diagnostico
    public class SalasDiagnostico : Espacio
        {
            //atributos
            private string tipoEstudio;
            //Propiedades
            public string TipoEstudio { get { return tipoEstudio; } set { tipoEstudio = value; } }
            //Constructor
            public SalasDiagnostico(int nroConsultorio, int piso, string ala, Medico medico, string tipoEstudio) : base(nroConsultorio, piso, ala, medico)
            {
                this.tipoEstudio = tipoEstudio;
            }
            //Metodo
            public override Espacio imprimirEspacio()
            { 
                Console.WriteLine($" Sala de diagnostico: Consultorio Nro: {NroConsultorio}, Piso: {Piso}, Ala: {Ala}, Medico: {Medico.Nombre} {Medico.Apellido},Tipo de Estudio: {tipoEstudio}");
            return this;
            }

        }
    public class SalaUrgencia : Espacio
        {
        //atributos
        private bool libre;
        private Paciente paciente;
        //Propiedades
        public bool Libre { get { return libre; } set { libre = value; } }
        public Paciente Paciente { get { return paciente; } set { paciente = value; } }
        //Constructor
        public SalaUrgencia(int nroConsultorio, int piso, string ala, Medico medico, bool libre, Paciente paciente) : base(nroConsultorio, piso, ala, medico)
        {
            this.libre = libre;
            this.paciente = paciente;
        }
        // Constructor sobrecargado sin paciente
        public SalaUrgencia(int nroConsultorio, int piso, string ala, Medico medico, bool libre) : base(nroConsultorio, piso, ala, medico)
        {
            this.libre = libre;
        }
        // Metodo
        public override Espacio imprimirEspacio()
        {
            if (!libre && paciente != null)
            {
                Console.WriteLine($" Sala de Urgencia: Consultorio Nro: {NroConsultorio}, Piso: {Piso}, Ala: {Ala}, Medico: {Medico.Nombre} {Medico.Apellido},Ocupado, Paciente: {paciente.Nombre} {paciente.Apellido}");
            }
            else
            {
                Console.WriteLine($" Sala de Urgencia: Consultorio Nro: {NroConsultorio}, Piso: {Piso}, Ala: {Ala}, Medico: {Medico.Nombre} {Medico.Apellido},Libre ");
            }
            return this;
        }
    }
    }   
