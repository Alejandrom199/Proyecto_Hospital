using CapaServicios.Interfaces;
using CapaServicios.Servicios;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Controllers
{
    public class FacturacionController
    {
        private IFacturacion interface_facturacion = new FacturacionService();
        /**
        * Método para obtener la lista de las Facturaciones
        **/
        public DataTable GetListaFacturaciones()
        {
            Console.WriteLine("entro al lista Facturaciones");
            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_facturacion.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Facturaciones." + e.Message);
            }
        }
    }
}
