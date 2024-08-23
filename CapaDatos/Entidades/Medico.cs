using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Medico
    {
        private int id_medico;
        private string nombre;
        private string apellido;
        private string cedula;
        private Especialidad especialidad;
        private string numero_licencia;
        private string sexo;
        private string telefono;
        private string email;
        private Horario horario_atencion;
        private Consultorio consultorio;
        private DateTime fecha_contratacion;

        // Constructor parametrizado
        public Medico(int id_medico, string nombre, string apellido, string cedula, Especialidad especialidad, string numero_licencia, string sexo, string telefono, string email, Horario horario_atencion, Consultorio consultorio, DateTime fecha_contratacion)
        {
            this.id_medico = id_medico;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.especialidad = especialidad;
            this.numero_licencia = numero_licencia;
            this.sexo = sexo;
            this.telefono = telefono;
            this.email = email;
            this.horario_atencion = horario_atencion;
            this.consultorio = consultorio;
            this.fecha_contratacion = fecha_contratacion;
        }

        // Constructor por defecto
        public Medico()
        {
            id_medico = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            cedula = string.Empty;
            especialidad = null;
            numero_licencia = string.Empty;
            sexo = string.Empty;
            telefono = string.Empty;
            email = string.Empty;
            horario_atencion = null;
            consultorio = null;
            fecha_contratacion = DateTime.Now;
        }

        // Propiedades
        public int IdMedico
        {
            get { return id_medico; }
            set { id_medico = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; }
        }

        public Especialidad Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public string NumeroLicencia
        {
            get { return numero_licencia; }
            set { numero_licencia = value; }
        }

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public Horario HorarioAtencion
        {
            get { return horario_atencion; }
            set { horario_atencion = value; }
        }

        public Consultorio Consultorio
        {
            get { return consultorio; }
            set { consultorio = value; }
        }

        public DateTime FechaContratacion
        {
            get { return fecha_contratacion; }
            set { fecha_contratacion = value; }
        }
    }
}
