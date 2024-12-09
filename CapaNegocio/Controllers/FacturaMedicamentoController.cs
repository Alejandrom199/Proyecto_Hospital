using CapaDatos.Entidades;
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
    public class FacturaMedicamentoController
    {
        private IFacturaMedicamento interface_facturaMedicamento = new FacturaMedicamentoService();
 

        /**
         * Método para realizar una inserción de un Facturacion
         **/

        public bool AgregarFacturaMedicamento(int factura_id, int medicamento_id, int cantidad)
        {
            try
            {

                return interface_facturaMedicamento.agregar(new FacturaMedicamento
                {
                    FacturaId = factura_id,
                    MedicamentoId = medicamento_id,
                    Cantidad = cantidad
                });
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear FacturaMedicamento desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Medicamentos
        **/
        public int ObtenerIdMedicamentoParaFacturacionMedicamento(string nombre)
        {
            try
            {
                return interface_facturaMedicamento.ObtenerIdMedicamentoParaFacturaMedicamento(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id del FacturaMedicamento desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las FacturaMedicamento
        **/
        public DataTable GetListaFacturaMedicamento(int factura_id)
        {
            Console.WriteLine("entro al lista Medicos");
            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_facturaMedicamento.listarConId(factura_id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de FacturaMedicamento desde Controlador, " + e.Message);
            }
        }

        public decimal GetValorMontoTotal(int facturaId)
        {

            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_facturaMedicamento.ValorMontoTotal(facturaId);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el valor de la factura:"+facturaId+", desde Controlador, " + e.Message);
            }
        }

    }
}
