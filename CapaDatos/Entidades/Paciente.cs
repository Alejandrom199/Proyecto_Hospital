using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Paciente
    {
        private int id_paciente;
        private string nombre;
        private string apellido;
        private string cedula;
        private DateTime fecha_nacimiento;
        private string sexo;
        private string direccion;
        private string telefono;
        private string email;
        private DateTime fecha_registro;
        private string historial_medico;

        // Constructor parametrizado
        public Paciente(int id_paciente, string nombre, string apellido, string cedula, DateTime fecha_nacimiento, string sexo, string direccion, string telefono, string email, string nss, DateTime fecha_registro, string historial_medico)
        {
            this.id_paciente = id_paciente;
            this.nombre = nombre;
            this.apellido = apellido;
            this.cedula = cedula;
            this.fecha_nacimiento = fecha_nacimiento;
            this.sexo = sexo;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.fecha_registro = fecha_registro;
            this.historial_medico = historial_medico;
        }

        // Constructor por defecto
        public Paciente()
        {
            id_paciente = 0;
            nombre = string.Empty;
            apellido = string.Empty;
            cedula = string.Empty;
            fecha_nacimiento = DateTime.Now;
            sexo = string.Empty;
            direccion = string.Empty;
            telefono = string.Empty;
            email = string.Empty;
            fecha_registro = DateTime.Now;
            historial_medico = string.Empty;
        }

        // Propiedades
        public int IdPaciente
        {
            get { return id_paciente; }
            set { id_paciente = value; }
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

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
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

        public DateTime FechaRegistro
        {
            get { return fecha_registro; }
            set { fecha_registro = value; }
        }

        public string HistorialMedico
        {
            get { return historial_medico; }
            set { historial_medico = value; }
        }
    }

}
