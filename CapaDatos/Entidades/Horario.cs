using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Horario
    {
        private int id;
        private TimeSpan horaInicio;
        private TimeSpan horaFin;
        private string diaInicio;
        private string diaFin;

        public Horario(int id, TimeSpan horaInicio, TimeSpan horaFin, string diaInicio, string diaFin)
        {
            this.id = id;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.diaInicio = diaInicio;
            this.diaFin = diaFin;
        }

        public Horario()
        {
            id = 0;
            horaInicio = TimeSpan.MaxValue;
            horaFin = TimeSpan.MaxValue;
            diaInicio = string.Empty;
            diaFin = string.Empty;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public TimeSpan HoraInicio
        {
            get { return horaInicio; }
            set { horaInicio = value; }
        }

        public TimeSpan HoraFin
        {
            get { return horaFin; }
            set { horaFin = value; }
        }

        public string DiaInicio
        {
            get { return diaInicio; }
            set { diaInicio = value; }
        }

        public string DiaFin
        {
            get { return diaFin; }
            set { diaFin = value; }
        }
    }
}
