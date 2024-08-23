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
    public class ConsultorioService : IConsultorio
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Consultorio entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_CONSULTORIO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@numero", entidad.Numero),
                    new SqlParameter("@piso", entidad.Piso)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Consultorio: " + e.Message);
            }
        }

        public bool eliminar(Consultorio entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_CONSULTORIO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Consultorio: " + e.Message);
            }
        }

        public DataTable listar()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_CONSULTORIOS";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Consultorios." + e.Message);
            }
        }

        public bool modificar(Consultorio entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_CONSULTORIO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                    new SqlParameter("@numero", entidad.Numero),
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@piso", entidad.Piso)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Consultorio: " + e.Message);
            }
        }
    }
}
