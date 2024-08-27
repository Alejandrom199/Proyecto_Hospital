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
    public class MedicamentoController
    {
        private IMedicamento interface_medicamento = new MedicamentoService();

        /**
         * Método para realizar una inserción de un Medicamento
         **/
        public bool AgregarMedicamento(string nombre_comercial, string nombre_generico, int presentacion_id, string dosis, DateTime fecha_expiracion, string lote, decimal precio, int proveedor_id, string indicaciones)
        {
            try
            {

                return interface_medicamento.agregar(new Medicamento
                {
                    NombreComercial = nombre_comercial,
                    NombreGenerico = nombre_generico,
                    PresentacionId = presentacion_id,
                    Dosis = dosis,
                    FechaExpiracion = fecha_expiracion,
                    Lote = lote,
                    Precio = precio,
                    ProveedorId = proveedor_id,
                    Indicaciones = indicaciones
                });
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Medicamento desde Controlador, " + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de un Medicamento
         **/
        public bool ModificarMedicamento(int id, string nombre_comercial, string nombre_generico, int presentacion_id, string dosis, DateTime fecha_expiracion, string lote, decimal precio, int proveedor_id, string indicaciones)
        {
            try
            {
                return interface_medicamento.modificar(new Medicamento
                {
                    IdMedicamento = id,
                    NombreComercial = nombre_comercial,
                    NombreGenerico = nombre_generico,
                    PresentacionId = presentacion_id,
                    Dosis = dosis,
                    FechaExpiracion = fecha_expiracion,
                    Lote = lote,
                    Precio = precio,
                    ProveedorId = proveedor_id,
                    Indicaciones = indicaciones
                });

            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Medicamento desde Controlador, " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de un Medicamento
         **/
        public bool EliminarMedicamento(int id)
        {
            try
            {
                return interface_medicamento.eliminar(new Medicamento
                {
                    IdMedicamento = id
                });
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Medicamento desde Controlador, " + e.Message);

            }
        }

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

        /**
        * Método para obtener el Medicamento mediante su Id
        **/
        public Dictionary<string, object> GetMedicamentoPorId(int id)
        {
            try
            {
                return interface_medicamento.buscar_por_ID(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener Medicamento por id desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los nombres de Presentaciones
        **/
        public Dictionary<int, string> ObtenerPresentacionesParaMedicamento()
        {
            try
            {
                return interface_medicamento.ObtenerPresentacionesParaMedicamento();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Presentaciones desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los nombres de Proveedores
        **/
        public Dictionary<int, string> ObtenerProveedoresParaMedicamento()
        {
            try
            {
                return interface_medicamento.ObtenerProveedoresParaMedicamento();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Proveedores desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Presentaciones
        **/
        public int ObtenerIdPresentacionParaMedicamento(string nombre)
        {
            try
            {
                return interface_medicamento.ObtenerIdPresentacionParaMedicamento(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id de la Presentacion desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el id de los Proveedores
        **/
        public int ObtenerIdProveedorParaMedicamento(string nombre)
        {
            try
            {
                return interface_medicamento.ObtenerIdProveedorParaMedicamento(nombre);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el id del Proveedor desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el nombre de la Presentacion mediante el id del Medicamento
        **/
        public string ObtenerNombrePresentacionMedianteIdMedico(int id)
        {
            try
            {
                return interface_medicamento.ObtenerPresentacionMedianteIdMedicamento(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el nombre de la Presentacion mediante el id del Medicamento desde Controlador, " + e.Message);
            }
        }

        /**
        * Método para obtener el Proveedor mediante el id del Medicamento
        **/
        public string ObtenerNombreProveedorMedianteIdMedico(int id)
        {
            try
            {
                return interface_medicamento.ObtenerProveedorMedianteIdMedicamento(id);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener el Proveedor mediante el id del Medicamento desde Controlador, " + e.Message);
            }
        }
    }
}
