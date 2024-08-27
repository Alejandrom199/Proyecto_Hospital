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
    public class ProveedorController
    {
        private IProveedor interface_proveedor = new ProveedorService();

        /**
         * Método para realizar una inserción de un Proveedor
         **/
        public bool AgregarProveedor(string nombre, string direccion, string telefono, string email, string nombre_de_contacto)
        {
            try
            {
                return interface_proveedor.agregar(
                    new Proveedor
                    {
                        Nombre = nombre,
                        Direccion = direccion,
                        Telefono = telefono,
                        Email = email,
                        NombreDeContacto = nombre_de_contacto
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Proveedor: " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los Proveedores
        **/
        public DataTable GetListaProveedores()
        {
            try
            {
                return interface_proveedor.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Proveedores." + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de un Proveedor
         **/
        public bool ModificarProveedor(int id, string nombre, string direccion, string telefono, string email, string nombre_de_contacto)
        {
            try
            {
                return interface_proveedor.modificar(
                    new Proveedor
                    {
                        Id = id,
                        Nombre = nombre,
                        Direccion = direccion,
                        Telefono = telefono,
                        Email = email,
                        NombreDeContacto = nombre_de_contacto
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Proveedor: " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de un Proveedor
         **/
        public bool EliminarProveedor(int id)
        {
            try
            {

                return interface_proveedor.eliminar(
                    new Proveedor
                    {
                        Id = id,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Proveedor: " + e.Message);

            }
        }
    }
}
