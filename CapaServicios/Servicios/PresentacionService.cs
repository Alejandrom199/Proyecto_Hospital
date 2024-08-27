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
    public class PresentacionService : IPresentacion
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Presentacion entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_PRESENTACION";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", entidad.Nombre)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Presentacion: " + e.Message);
            }
        }

        public bool eliminar(Presentacion entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_PRESENTACION";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Presentacion: " + e.Message);
            }
        }

        public DataTable listar()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_PRESENTACIONES";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Presentaciones." + e.Message);
            }
        }

        public bool modificar(Presentacion entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_PRESENTACION";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                    new SqlParameter("@nombre", entidad.Nombre)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Presentacion: " + e.Message);
            }
        }
    }
}
