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
    public class MedicamentoController
    {
        private IMedicamento interface_medicamento = new MedicamentoService();
        /**
        * Método para obtener la lista de las Medicamentos
        **/
        public DataTable GetListaMedicamentos()
        {
            Console.WriteLine("entro al lista Medicamentos");
            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_medicamento.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Medicamentos." + e.Message);
            }
        }
    }
}
