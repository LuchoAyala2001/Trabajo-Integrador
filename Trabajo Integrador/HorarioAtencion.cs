using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Integrador
{
    public class HorarioAtencion
    {
        //atributos
        private TimeOnly horaApertura;
        private TimeOnly horaCierre;
        private DayOfWeek diaSemana;
        // propiedades
        public TimeOnly HoraApertura { get { return horaApertura; } set { horaApertura = value; } }
        public TimeOnly HoraCierre { get { return horaCierre; } set { horaCierre = value; } }
        public DayOfWeek DiaSemana { get { return diaSemana; } set { diaSemana = value; } }

        //constructores

        public HorarioAtencion(TimeOnly horaApertura, TimeOnly horaCierre, DayOfWeek diaSemana)
        {
            this.horaApertura = horaApertura;
            this.horaCierre = horaCierre;
            this.diaSemana = diaSemana;
        }
    }
}
