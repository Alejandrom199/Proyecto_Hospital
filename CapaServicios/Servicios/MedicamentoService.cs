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
    public class MedicamentoService : IMedicamento
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Medicamento entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_MEDICAMENTO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre_comercial", entidad.NombreComercial),
                    new SqlParameter("@nombre_generico", entidad.NombreGenerico),
                    new SqlParameter("@presentacion_id", entidad.PresentacionId),
                    new SqlParameter("@dosis", entidad.Dosis),
                    new SqlParameter("@fecha_expiracion", entidad.FechaExpiracion),
                    new SqlParameter("@lote", entidad.Lote),
                    new SqlParameter("@precio", entidad.Precio),
                    new SqlParameter("@proveedor_id", entidad.ProveedorId),
                    new SqlParameter("@indicaciones", entidad.Indicaciones)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Medicamento: " + e.Message);
            }
        }

        public Dictionary<string, object> buscar_por_ID(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_MEDICAMENTO_POR_ID";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id),
            };

            return manejo_sql.EjecutarSPSelectMedicamento(nombreStoredProcedure, parametros);
        }

        public bool eliminar(Medicamento entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_MEDICAMENTO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.IdMedicamento),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Medicamento: " + e.Message);
            }
        }

        public DataTable listar()
        {
            Console.WriteLine("entro a la lista de Medicamentos");
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_MEDICAMENTOS";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Medicamentos." + e.Message);
            }
        }

        public bool modificar(Medicamento entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_MEDICAMENTO";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.IdMedicamento),
                    new SqlParameter("@nombre_comercial", entidad.NombreComercial),
                    new SqlParameter("@nombre_generico", entidad.NombreGenerico),
                    new SqlParameter("@presentacion_id", entidad.PresentacionId),
                    new SqlParameter("@dosis", entidad.Dosis),
                    new SqlParameter("@fecha_expiracion", entidad.FechaExpiracion),
                    new SqlParameter("@lote", entidad.Lote),
                    new SqlParameter("@precio", entidad.Precio),
                    new SqlParameter("@proveedor_id", entidad.ProveedorId),
                    new SqlParameter("@indicaciones", entidad.Indicaciones)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Medicamento: " + e.Message);
            }
        }

        public int ObtenerIdPresentacionParaMedicamento(string nombre)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_PRESENTACIÓN";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public int ObtenerIdProveedorParaMedicamento(string nombre)
        {
            string nombreStoredProcedure = "SP_OBTENER_ID_PROVEEDOR";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@nombre", nombre)
            };

            return manejo_sql.EjecutarSPSelectInt(nombreStoredProcedure, parametros);
        }

        public Dictionary<int, string> ObtenerPresentacionesParaMedicamento()
        {
            string nombreStoredProcedure = "SP_OBTENER_PRESENTACIONES";

            return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure, "nombre", null);
        }

        public string ObtenerPresentacionMedianteIdMedicamento(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_NOMBRE_PRESENTACION_MEDIANTE_ID_MEDICAMENTO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return manejo_sql.EjecutarSPSelectString(nombreStoredProcedure, parametros);
        }

        public Dictionary<int, string> ObtenerProveedoresParaMedicamento()
        {
            string nombreStoredProcedure = "SP_OBTENER_PROVEEDORES";

            return manejo_sql.EjecutarSPSelectIntToStringUnCampo(nombreStoredProcedure, "nombre", null);
        }

        public string ObtenerProveedorMedianteIdMedicamento(int id)
        {
            string nombreStoredProcedure = "SP_OBTENER_NOMBRE_PROVEEDOR_MEDIANTE_ID_MEDICAMENTO";

            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@id", id)
            };

            return manejo_sql.EjecutarSPSelectString(nombreStoredProcedure, parametros);
        }
    }
}
