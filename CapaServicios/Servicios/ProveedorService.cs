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
    public class ProveedorService : IProveedor
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Proveedor entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_CREATE_PROVEEDOR";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@direccion", entidad.Direccion),
                    new SqlParameter("@telefono", entidad.Telefono),
                    new SqlParameter("@email", entidad.Email),
                    new SqlParameter("@nombre_de_contacto", entidad.NombreDeContacto)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Proveedor: " + e.Message);
            }
        }

        public bool eliminar(Proveedor entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_ELIMINAR_PROVEEDOR";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Proveedor: " + e.Message);
            }
        }

        public DataTable listar()
        {
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_PROVEEDORES";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Proveedores." + e.Message);
            }
        }

        public bool modificar(Proveedor entidad)
        {
            try
            {
                string nombreStoredProcedure = "SP_MODIFICAR_PROVEEDOR";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@id", entidad.Id),
                    new SqlParameter("@nombre", entidad.Nombre),
                    new SqlParameter("@direccion", entidad.Direccion),
                    new SqlParameter("@telefono", entidad.Telefono),
                    new SqlParameter("@email", entidad.Email),
                    new SqlParameter("@nombre_de_contacto", entidad.NombreDeContacto)
                };

                return manejo_sql.EjecutarSPSql(nombreStoredProcedure, parametros);
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Proveedor: " + e.Message);
            }
        }
    }
}
