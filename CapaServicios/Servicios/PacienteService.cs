using CapaDatos.Entidades;
using CapaPersistencia;
using CapaServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaServicios.Servicios
{
    public class PacienteService : IPaciente
    {
        private ManageSQL manejo_sql = new ManageSQL();

        public bool agregar(Paciente entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_PACIENTE";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@apellido", entidad.Apellido),
                    new SqlParameter("@cedula", entidad.Cedula),
                    new SqlParameter("@fecha_nacimiento", entidad.FechaNacimiento),
                    new SqlParameter("sexo", entidad.Sexo),
                    new SqlParameter("@direccion", entidad.Direccion),
                    new SqlParameter("@telefono", entidad.Telefono),
                    new SqlParameter("@email", entidad.Email),
                    new SqlParameter("@fecha_registro", entidad.FechaRegistro),
                    new SqlParameter("@historial_medico", entidad.HistorialMedico),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Candidata: " + e.Message);
            }
        }

        public Dictionary<string, object> buscar_por_ID(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_PACIENTE_POR_ID";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };

            return manejo_sql.EjecutarSPSelectPaciente(nombreStoredProcedure, parametros);

        }

        public bool eliminar(Paciente entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_PACIENTE";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.IdPaciente),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Paciente: " + e.Message);
            }
        }

        public DataTable filtrar_por_apellido(string apellido)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_PACIENTE_POR_APELLIDO";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@apellido", apellido),
                };
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por apellido." + e.Message);
            }
        }

        public DataTable filtrar_por_cedula(string cedula)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_PACIENTE_POR_CEDULA";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@cedula", cedula),
                };
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por cédula." + e.Message);
            }
        }

        public DataTable filtrar_por_ID(int id)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_PACIENTE_POR_ID";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", id),
                };
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por id." + e.Message);
            }
        }

        public DataTable filtrar_por_nombre(string nombre)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_PACIENTE_POR_NOMBRE";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", nombre),
                };
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes por nombre." + e.Message);
            }
        }

        public DataTable listar()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_PACIENTES";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Pacientes." + e.Message);
            }
        }

        public bool modificar(Paciente entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_PACIENTE";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.IdPaciente),
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@apellido", entidad.Apellido),
                    new SqlParameter("@cedula", entidad.Cedula),
                    new SqlParameter("@fecha_nacimiento", entidad.FechaNacimiento),
                    new SqlParameter("sexo", entidad.Sexo),
                    new SqlParameter("@direccion", entidad.Direccion),
                    new SqlParameter("@telefono", entidad.Telefono),
                    new SqlParameter("@email", entidad.Email),
                    new SqlParameter("@fecha_registro", entidad.FechaRegistro),
                    new SqlParameter("@historial_medico", entidad.HistorialMedico),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Paciente: " + e.Message);
            }
        }
    }
}
