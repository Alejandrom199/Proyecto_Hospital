using CapaDatos.Entidades;
using CapaPersistencia;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaServicios.Interfaces;

namespace CapaServicios.Servicios
{
    public class HorarioService : IHorario
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Horario entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_HORARIO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@horaInicio", entidad.HoraInicio),
                    new SqlParameter("@horaFin", entidad.HoraFin),
                    new SqlParameter("@diaInicio", entidad.DiaInicio),
                    new SqlParameter("@diaFin", entidad.DiaFin)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Horario: " + e.Message);
            }
        }

        public bool eliminar(Horario entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_HORARIO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Horario: " + e.Message);
            }
        }

        public DataTable listar()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_HORARIOS";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Horarios." + e.Message);
            }
        }

        public bool modificar(Horario entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_HORARIO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                    new SqlParameter("@horaInicio", entidad.HoraInicio),
                    new SqlParameter("@horaFin", entidad.HoraFin),
                    new SqlParameter("@diaInicio", entidad.DiaInicio),
                    new SqlParameter("@diaFin", entidad.DiaFin)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Horario: " + e.Message);
            }
        }
    }
}
