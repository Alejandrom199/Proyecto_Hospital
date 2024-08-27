using CapaDatos.Entidades;
using CapaServicios.Interfaces;
using CapaServicios.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaNegocio.Controllers
{
    public class MedicoController
    {
        private IMedico interface_medico = new MedicoService();

        /**
         * Método para realizar una inserción de un Paciente
         **/
        public bool AgregarMedico(string nombre, string apellido, string cedula, DateTime fecha_nacimiento, int especialidad_id, string numero_licencia, string sexo, string telefono, string email, int horario_atencion_id, int consultorio_id)
        {
            try
            {

                return interface_medico.agregar(new Medico
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Cedula = cedula,
                    FechaNacimiento = fecha_nacimiento,
                    EspecialidadId = especialidad_id,
                    NumeroLicencia = numero_licencia,
                    Sexo = sexo,
                    Telefono = telefono,
                    Email = email,
                    HorarioAtencionId =horario_atencion_id,
                    ConsultorioId = consultorio_id,
                });
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Médico desde Controlador, " + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de un Médico
         **/
        public bool ModificarMedico(int id, string nombre, string apellido, string cedula, DateTime fecha_nacimiento, int especialidad_id, string numero_licencia, string sexo, string telefono, string email, int horario_atencion_id, int consultorio_id)
        {
            try
            {
                return interface_medico.modificar(new Medico
                {
                    IdMedico = id,
                    Nombre = nombre,
                    Apellido = apellido,
                    Cedula = cedula,
                    FechaNacimiento = fecha_nacimiento,
                    EspecialidadId = especialidad_id,
                    NumeroLicencia = numero_licencia,
                    Sexo = sexo,
                    Telefono = telefono,
                    Email = email,
                    HorarioAtencionId = horario_atencion_id,
                    ConsultorioId = consultorio_id,
                });

            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Médico desde Controlador, " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de un Médico
         **/
        public bool EliminarMedico(int id)
        {
            try
            {
                return interface_medico.eliminar(new Medico
                {
                    IdMedico = id
                });
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Médico desde Controlador, " + e.Message);

            }
        }
    

        /**
        * Método para obtener la lista de las Medicos
        **/
        public DataTable GetListaMedicos()
        {
            Console.WriteLine("entro al lista Medicos");
            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_medico.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Medicos desde Controlador, " + e.Message);
            }
        }

        public Dictionary<string, object> GetMedicoPorId(int id)
        {
            try
            {
                return interface_medico.buscar_por_ID(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener Médico por id desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los nombres de Especialidades
        **/
        public Dictionary<int, string> ObtenerEspecialidadesParaMedico()
        {
            try
            {
                return interface_medico.ObtenerEspecialidadesParaMedico();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Especialidades desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los nombres de Consultorios
        **/
        public Dictionary<int, string> ObtenerConsultoriosParaMedico()
        {
            try
            {
                return interface_medico.ObtenerConsultoriosParaMedico();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Consultorios desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las horas de Horarios
        **/
        public Dictionary<int, string> ObtenerHorariosParaMedico()
        {
            try
            {
                return interface_medico.ObtenerHorariosParaMedico();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Horarios desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Especialidades
        **/
        public int ObtenerIdEspecialidadParaMedico(string nombre)
        {
            try
            {
                return interface_medico.ObtenerIdEspecialidadParaMedico(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id del Especialidad desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Consultorios
        **/
        public int ObtenerIdConsultorioParaMedico(string nombre)
        {
            try
            {
                return interface_medico.ObtenerIdConsultorioParaMedico(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id del Consultorio desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Horarios
        **/
        public int ObtenerIdHorarioParaMedico(TimeSpan horaInicio, TimeSpan horaFin)
        {
            try
            {
                return interface_medico.ObtenerIdHorarioParaMedico(horaInicio, horaFin);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id del Horario desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el nombre de la Especialidad mediante el id del Médico
        **/
        public string ObtenerNombreEspecialidadMedianteIdMedico(int id)
        {
            try
            {
                return interface_medico.ObtenerEspecialidadMedianteIdMedico(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el nombre de la Especialidad mediante el id del Médico desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el nombre del Consultorio mediante el id del Médico
        **/
        public string ObtenerNombreConsultorioMedianteIdMedico(int id)
        {
            try
            {
                return interface_medico.ObtenerConsultorioMedianteIdMedico(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el nombre del Consultorio mediante el id del Médico desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el Horario mediante el id del Médico
        **/
        public string ObtenerHorarioMedianteIdMedico(int id)
        {
            try
            {
                return interface_medico.ObtenerHorarioMedianteIdMedico(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el Horario mediante el id del Médico desde Controlador, " + e.Message);
            }
        }
    }
}
