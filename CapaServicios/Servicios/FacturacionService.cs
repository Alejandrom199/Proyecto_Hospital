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
    public class FacturacionService : IFacturacion
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Facturacion entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_FACTURA";

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("FacturacionService: Error al crear Factura: " + e.Message);
            }
        }

        public bool eliminar(Facturacion entidad)
        {
            throw new NotImplementedException();
        }

        public DataTable listar()
        {
            Console.WriteLine("entro a la lista de Facturacion");
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_FACTURAS";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("FacturacionService: Error al obtener listado de Facturaciones." + e.Message);
            }
        }

        public bool modificar(Facturacion entidad)
        {

            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_FACTURA";

                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@id", entidad.Id),
                new SqlParameter("@paciente_id", entidad.PacienteId),
                new SqlParameter("@medico_id", entidad.MedicoId),
                new SqlParameter("@metodo_pago", entidad.MetodoPago),
                new SqlParameter("@observaciones", entidad.Observaciones),
                new SqlParameter("@monto_total", entidad.MontoTotal)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("FacturacionService: Error al modificar Factura: " + e.Message);
            }
            
        }

        public int ObtenerFacturaIdReciente()
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_FACTURA_RECIENTE";

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, null);
        }

        public int ObtenerIdMedicamentoParaFacturacion(string nombre)
        {
            throw new NotImplementedException();
        }

        public int ObtenerIdMedicoParaFacturacion(string nombre)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_MEDICO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public int ObtenerIdPacienteParaFacturacion(string nombre)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_PACIENTE";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public string ObtenerMedicamentoMedianteIdFacturacion(int id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> ObtenerMedicamentosParaFacturacion()
        {
            string nombreStoredProcedure = "SP_OBTENER_MEDICAMENTOS";

            return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure, "nombre_comercial", null);
        }

        public string ObtenerMedicoMedianteIdFacturacion(int id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> ObtenerMedicosParaFacturacion()
        {
            string nombreStoredProcedure = "SP_OBTENER_MEDICOS";

            return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure, "nombre", null);
        }

        public string ObtenerPacienteMedianteIdFacturacion(int id)
        {
            throw new NotImplementedException();
        }

        public Dictionary<int, string> ObtenerPacientesParaFacturacion()
        {
            string nombreStoredProcedure = "SP_OBTENER_PACIENTES";

            return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure, "nombre", null);
        }

        public bool ObtenerMontoTotal(int facturaId)
        {
            string nombreStoredProcedure = "SP_OBTENER_MONTO_TOTAL";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@factura_id", facturaId),
            };

            return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
        }

        public decimal ValorMontoTotal(int facturaId)
        {

            string nombreStoredProcedure = "SP_VALOR_MONTO_TOTAL";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@factura_id", facturaId),
            };

            return manejo_sql.EjecutarSPSelectDecimal(nombreStoredProcedure, parametros);
        }
    }
}
