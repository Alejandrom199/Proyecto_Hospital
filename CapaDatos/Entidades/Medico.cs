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
        private DateTime fecha_nacimiento;
        private int especialidad_id;
        private string numero_licencia;
        private string sexo;
        private string telefono;
        private string email;
        private int horario_atencion_id;
        private int consultorio_id;
        private DateTime fecha_contratacion;

        // Constructor parametrizado
        public Medico(int id_medico, string nombre, string apellido, string cedula, DateTime fecha_nacimiento, int especialidad_id, string numero_licencia, string sexo, string telefono, string email, int horario_atencion_id, int consultorio_id, DateTime fecha_contratacion)
        {
            this.id_medico = id_medico;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fecha_nacimiento = fecha_nacimiento;
            this.especialidad_id = especialidad_id;
            this.numero_licencia = numero_licencia;
            this.sexo = sexo;
            this.telefono = telefono;
            this.email = email;
            this.horario_atencion_id = horario_atencion_id;
            this.consultorio_id = consultorio_id;
            this.fecha_contratacion = fecha_contratacion;
        }

        // Constructor por defecto
        public Medico()
        {
            id_medico = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            cedula = string.Empty;
            fecha_nacimiento = DateTime.Now;
            especialidad_id = 0;
            numero_licencia = string.Empty;
            sexo = string.Empty;
            telefono = string.Empty;
            email = string.Empty;
            horario_atencion_id = 0;
            consultorio_id = 0;
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

        public DateTime FechaNacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        public int EspecialidadId
        {
            get { return especialidad_id; }
            set { especialidad_id = value; }
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

        public int HorarioAtencionId

        {
            get { return horario_atencion_id; }
            set { horario_atencion_id = value; }
        }

        public int ConsultorioId
        {
            get { return consultorio_id; }
            set { consultorio_id = value; }
        }

        public DateTime FechaContratacion
        {
            get { return fecha_contratacion; }
            set { fecha_contratacion = value; }
        }
    }
}
