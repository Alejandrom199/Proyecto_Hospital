using CapaDatos.Entidades;
using CapaServicios.Interfaces;
using CapaServicios.Servicios;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Controllers
{
    public class PacienteController
    {
        private IPaciente interface_paciente = new PacienteService();

        /**
         * Método para realizar una inserción de un Paciente
         **/
        public bool AgregarPaciente(string nombre, string apellido, string cedula, DateTime fecha_nacimiento, string sexo, string direccion, string telefono, string email, DateTime fecha_registro)
        {
            try
            {
                Paciente paciente = new Paciente
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Cedula = cedula,
                    FechaNacimiento = fecha_nacimiento,
                    Sexo = sexo,
                    Direccion = direccion,
                    Telefono = telefono,
                    Email = email,
                    FechaRegistro = fecha_registro
                };

                return interface_paciente.agregar(paciente);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Paciente: " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las Pacientes
        **/
        public DataTable GetListaPacientes()
        {
            Console.WriteLine("entro al lista Pacientes");
            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_paciente.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes." + e.Message);
            }
        }

        public Dictionary<string, object> GetPacientePorId(int id)
        {
            try
            {
                return interface_paciente.buscar_por_ID(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener Paciente por id." + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las Pacientes mediante ID
        **/
        public DataTable FiltrarListaPacientesPorId(int id)
        {
            try
            {
                return interface_paciente.filtrar_por_ID(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por ID." + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las Pacientes mediante Nombre
        **/
        public DataTable FiltrarListaPacientesPorNombre(string nombre)
        {
            try
            {
                return interface_paciente.filtrar_por_nombre(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por nombre." + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las Pacientes mediante Apellido
        **/
        public DataTable FiltrarListaPacientesPorApellido(string apellido)
        {
            try
            {
                return interface_paciente.filtrar_por_apellido(apellido);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por apellido." + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las Pacientes mediante Cédula
        **/
        public DataTable FiltrarListaPacientesPorCedula(string cedula)
        {
            try
            {
                return interface_paciente.filtrar_por_cedula(cedula);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por cédula." + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de un Paciente
         **/
        public bool ModificarPaciente(int id, string nombre, string apellido, string cedula, DateTime fecha_nacimiento, string sexo, string direccion, string telefono, string email)
        {
            try
            {
                Paciente paciente = new Paciente
                {
                    IdPaciente = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Cedula = cedula,
                    FechaNacimiento = fecha_nacimiento,
                    Sexo = sexo,
                    Direccion = direccion,
                    Telefono = telefono,
                    Email = email
                };

                return interface_paciente.modificar(paciente);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Paciente: " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de un Paciente
         **/
        public bool EliminarPaciente(int id)
        {
            try
            {
                Paciente paciente = new Paciente
                {
                    IdPaciente = id,
                };

                return interface_paciente.eliminar(paciente);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Paciente: " + e.Message);

            }
        }
    }
}