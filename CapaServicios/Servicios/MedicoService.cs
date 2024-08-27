using CapaDatos.Entidades;
using CapaPersistencia;
using CapaServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaServicios.Servicios
{
    public class MedicoService : IMedico
    {
        private ManageSQL manejo_sql = new ManageSQL();

        public bool agregar(Medico entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_MEDICO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@apellido", entidad.Apellido),
                    new SqlParameter("@cedula", entidad.Cedula),
                    new SqlParameter("@fecha_nacimiento", entidad.FechaNacimiento),
                    new SqlParameter("@especialidad_id", entidad.EspecialidadId),
                    new SqlParameter("@numero_licencia", entidad.NumeroLicencia),
                    new SqlParameter("@sexo", entidad.Sexo),
                    new SqlParameter("@telefono", entidad.Telefono),
                    new SqlParameter("@email", entidad.Email),
                    new SqlParameter("@horario_atencion_id", entidad.HorarioAtencionId),
                    new SqlParameter("@consultorio_id", entidad.ConsultorioId),
                    new SqlParameter("@fecha_contratacion", entidad.FechaContratacion),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Médico: " + e.Message);
            }
        }

        public DataTable buscar_por_especialidad(string especialidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(Medico entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_MEDICO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.IdMedico),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Médico: " + e.Message);
            }
        }

        public DataTable listar()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_MEDICOS_COMPLETO";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Medicos." + e.Message);
            }
        }

        public bool modificar(Medico entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_MEDICO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.IdMedico),
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@apellido", entidad.Apellido),
                    new SqlParameter("@cedula", entidad.Cedula),
                    new SqlParameter("@fecha_nacimiento", entidad.FechaNacimiento),
                    new SqlParameter("@especialidad_id", entidad.EspecialidadId),
                    new SqlParameter("@numero_licencia", entidad.NumeroLicencia),
                    new SqlParameter("@sexo", entidad.Sexo),
                    new SqlParameter("@telefono", entidad.Telefono),
                    new SqlParameter("@email", entidad.Email),
                    new SqlParameter("@horario_atencion_id", entidad.HorarioAtencionId),
                    new SqlParameter("@consultorio_id", entidad.ConsultorioId),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Médico: " + e.Message);
            }
        }

        public Dictionary<int, string> ObtenerEspecialidadesParaMedico()
        {
            string nombreStoredProcedure = "SP_OBTENER_ESPECIALIDADES";

            //return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure,"id", null);
            return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure,"nombre", null);
        }

        public Dictionary<int, string> ObtenerConsultoriosParaMedico()
        {
            string nombreStoredProcedure = "SP_OBTENER_CONSULTORIOS";

            //return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure,"id", null);
            return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure, "nombre", null);
        }

        public Dictionary<int, string> ObtenerHorariosParaMedico()
        {
            string nombreStoredProcedure = "SP_OBTENER_HORARIOS";

            //return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure, "id", null);
            return manejo_sql.EjecutarSPSelectIntToStringDosCampos(nombreStoredProcedure, "horaInicio", "horaFin", null);
        }

        public int ObtenerIdEspecialidadParaMedico(string nombre)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_ESPECIALIDAD";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public int ObtenerIdConsultorioParaMedico(string nombre)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_CONSULTORIO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public int ObtenerIdHorarioParaMedico(TimeSpan horaInicio, TimeSpan horaFin)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_HORARIO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@horaInicio", horaInicio),
                new SqlParameter("@horaFin", horaFin)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public Dictionary<string, object> buscar_por_ID(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_MEDICO_POR_ID";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };

            return manejo_sql.EjecutarSPSelectMedico(nombreStoredProcedure, parametros);
        }

        public string ObtenerEspecialidadMedianteIdMedico(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_NOMBRE_ESPECIALIDAD_MEDIANTE_ID_MEDICO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return manejo_sql.EjecutarSPSelectString(nombreStoredProcedure, parametros);
        }

        public string ObtenerConsultorioMedianteIdMedico(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_NOMBRE_CONSULTORIO_MEDIANTE_ID_MEDICO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return manejo_sql.EjecutarSPSelectString(nombreStoredProcedure, parametros);
        }

        public string ObtenerHorarioMedianteIdMedico(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_HORARIOS_MEDIANTE_ID_MEDICO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return manejo_sql.EjecutarSPSelectString(nombreStoredProcedure, parametros);
        }
    }
}
