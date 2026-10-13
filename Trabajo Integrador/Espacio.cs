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
            Console.WriteLine($"Consultorio Nro: {nroConsultorio}, Piso: {piso}, Ala: {ala}, Medico: {medico.Nombre} {medico.Apellido}, Especialidad: {medico.Especialidad}");
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
            Console.WriteLine($"Consultorio Nro: {NroConsultorio}, Piso: {Piso}, Ala: {Ala}, Medico: {Medico.Nombre} {Medico.Apellido}, Especialidad: {Medico.Especialidad}, Receta: {receta}");
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
        public void AgregarHorario(HorarioAtencion horario)
        {
            horariosAtencion.Add(horario);
        }
    }
                                                            // Salas de diagnostico
    public class SalasDiagnostico : Espacio
        {
            //atributos
            private string tipoDiagnostico;
            //Propiedades
            public string TipoDiagnostico { get { return tipoDiagnostico; } set { tipoDiagnostico = value; } }
            //Constructor
            public SalasDiagnostico(int nroConsultorio, int piso, string ala, Medico medico, string tipoDiagnostico) : base(nroConsultorio, piso, ala, medico)
            {
                this.tipoDiagnostico = tipoDiagnostico;
            }
            //Metodo
            public override Espacio imprimirEspacio()
            {
                Console.WriteLine($"Consultorio Nro: {NroConsultorio}, Piso: {Piso}, Ala: {Ala}, Medico: {Medico.Nombre} {Medico.Apellido}, Especialidad: {Medico.Especialidad}, Tipo de Diagnóstico: {tipoDiagnostico}");
                return this;
            }

        }
    public class SalasUrgencias: Espacio
    {
        private int 
    }
}
