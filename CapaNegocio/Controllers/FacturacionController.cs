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
    public class FacturacionController
    {
        private IFacturacion interface_facturacion = new FacturacionService();
        private decimal montoAEnviar = 0;

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

        /**
        * Método para obtener la lista de los Pacientes de Facturaciones
        **/
        public Dictionary<int, string> ObtenerPacientesParaFacturacion()
        {
            try
            {
                return interface_facturacion.ObtenerPacientesParaFacturacion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Pacientes desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los Médicos de Facturaciones
        **/
        public Dictionary<int, string> ObtenerMedicosParaFacturacion()
        {
            try
            {
                return interface_facturacion.ObtenerMedicosParaFacturacion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Médicos desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los Medicamentos de Facturaciones
        **/
        public Dictionary<int, string> ObtenerMedicamentosParaFacturacion()
        {
            try
            {
                return interface_facturacion.ObtenerMedicamentosParaFacturacion();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Medicamentos desde Controlador, " + e.Message);
            }
        }

        /**
         * Método para realizar una inserción de un Facturacion
         **/
        public bool AgregarFacturacion()
        {
            try
            {
                return interface_facturacion.agregar(new Facturacion { });
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Facturacion desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Pacientes
        **/
        public int ObtenerIdPacienteParaFacturacion(string nombre)
        {
            try
            {
                return interface_facturacion.ObtenerIdPacienteParaFacturacion(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id del Paciente desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Medicos
        **/
        public int ObtenerIdMedicoParaFacturacion(string nombre)
        {
            try
            {
                return interface_facturacion.ObtenerIdMedicoParaFacturacion(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id del Medico desde Controlador, " + e.Message);
            }
        }

        public int ObtenerIdFacturaReciente()
        {
            try
            {
                return interface_facturacion.ObtenerFacturaIdReciente();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener factura reciente desde Controlador, " + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de una Factura
         **/
        public bool ModificarFactura(int id, int paciente_id, int medico_id, string metodo_pago, string observaciones, decimal montoTotal)
        {
            try
            {
                return interface_facturacion.modificar(new Facturacion
                {
                    Id = id,
                    PacienteId = paciente_id,
                    MedicoId = medico_id,
                    MetodoPago = metodo_pago,
                    Observaciones = observaciones,
                    MontoTotal = montoTotal
                });

            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Factura desde Controlador, " + e.Message);
            }
        }

        public decimal GetValorMontoTotal(int facturaId)
        {

            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_facturacion.ValorMontoTotal(facturaId);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el valor de la facturaMedicamentos:" + facturaId + ", desde Controlador, " + e.Message);
            }
        }

    }
}
