using CapaDatos.Entidades;
using CapaPersistencia;
using CapaServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
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
            throw new NotImplementedException();
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
                throw new Exception("Error al obtener listado de Facturaciones." + e.Message);
            }
        }

        public bool modificar(Facturacion entidad)
        {
            throw new NotImplementedException();
        }
    }
}
