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

namespace CapaServicios.Servicios
{
    public class EspecialidadService : IEspecialidad
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Especialidad entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_ESPECIALIDAD";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", entidad.Nombre)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Especialidad: " + e.Message);
            }
        }

        public bool eliminar(Especialidad entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_ESPECIALIDAD";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Especialidad: " + e.Message);
            }
        }

        public DataTable listar()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_ESPECIALIDADES";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Especialidades." + e.Message);
            }
        }

        public bool modificar(Especialidad entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_ESPECIALIDAD";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                    new SqlParameter("@nombre", entidad.Nombre),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Especialidad: " + e.Message);
            }
        }
    }
}
