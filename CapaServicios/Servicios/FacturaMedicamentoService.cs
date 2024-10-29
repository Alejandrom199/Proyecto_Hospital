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
    public class FacturaMedicamentoService : IFacturaMedicamento
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(FacturaMedicamento entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_FACTURA_MEDICAMENTO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@factura_id", entidad.FacturaId),
                    new SqlParameter("@medicamento_id", entidad.MedicamentoId),
                    new SqlParameter("@cantidad", entidad.Cantidad),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Factura Medicamento: " + e.Message);
            }
        }

        public bool eliminar(FacturaMedicamento entidad)
        {
            throw new NotImplementedException();
        }

        public DataTable listarConId(int factura_id)
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_FACTURAS_MEDICAMENTOS";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@factura_id", factura_id)
                };

                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de medicamentos facturas mediante su id." + e.Message);
            }
        }

        public DataTable listar()
        {
            throw new NotImplementedException();
        }

        public bool modificar(FacturaMedicamento entidad)
        {
            throw new NotImplementedException();
        }

        public int ObtenerIdMedicamentoParaFacturaMedicamento(string nombre_comercial)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_MEDICAMENTO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre_comercial", nombre_comercial)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public decimal ObtenerPrecioMedianteMedicamento(string nombre)
        {
            string nombreStoredProcedure = "SP_OBTENER_PRECIO_MEDICAMENTO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre_comercial", nombre)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }
    }
}
