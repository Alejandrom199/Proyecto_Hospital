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
    public class PresentacionController
    {
        private IPresentacion interface_presentacion = new PresentacionService();

        /**
         * Método para realizar una inserción de una Presentacion
         **/
        public bool AgregarPresentacion(string nombre)
        {
            try
            {
                return interface_presentacion.agregar(
                    new Presentacion
                    {
                        Nombre = nombre,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Presentacion: " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las Presentaciones
        **/
        public DataTable GetListaPresentaciones()
        {
            try
            {
                return interface_presentacion.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Presentacion." + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de una Presentacion
         **/
        public bool ModificarPresentacion(int id, string nombre)
        {
            try
            {
                return interface_presentacion.modificar(
                    new Presentacion
                    {
                        Id = id,
                        Nombre = nombre,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Presentacion: " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de una Presentacion
         **/
        public bool EliminarPresentacion(int id)
        {
            try
            {

                return interface_presentacion.eliminar(
                    new Presentacion
                    {
                        Id = id,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Presentacion: " + e.Message);

            }
        }
    }
}
