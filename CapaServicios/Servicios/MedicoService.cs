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
    public class MedicoService : IMedico
    {
        private ManageSQL manejo_sql = new ManageSQL();

        public bool agregar(Medico entidad)
        {
            throw new NotImplementedException();
        }

        public DataTable buscar_por_especialidad(string especialidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(Medico entidad)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public Dictionary<int, string> ObtenerEspecialidadesParaMedico()
        {
            string nombreStoredProcedure = "SP_OBTENER_ESPECIALIDADES";

            return manejo_sql.EjecutarSPSelectUnCampo(nombreStoredProcedure,"nombre", null);
        }

        public Dictionary<int, string> ObtenerConsultoriosParaMedico()
        {
            string nombreStoredProcedure = "SP_OBTENER_CONSULTORIOS";

            return manejo_sql.EjecutarSPSelectUnCampo(nombreStoredProcedure,"numero", null);
        }

        public Dictionary<int, string> ObtenerHorariosParaMedico()
        {
            string nombreStoredProcedure = "SP_OBTENER_HORARIOS";

            return manejo_sql.EjecutarSPSelectDosCampos(nombreStoredProcedure, "horaInicio", "horaFin", null);
        }
    }
}
