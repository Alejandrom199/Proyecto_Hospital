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
    public class ConsultorioController
    {
        private IConsultorio interface_consultorio = new ConsultorioService();

        /**
         * Método para realizar una inserción de una Consultorio
         **/
        public bool AgregarConsultorio(int numero, string nombre, int piso)
        {
            try
            {
                return interface_consultorio.agregar(
                    new Consultorio
                    {
                        Numero = numero,
                        Nombre = nombre,
                        Piso = piso
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Consultorio: " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los Consultorios
        **/
        public DataTable GetListaConsultorios()
        {
            try
            {
                return interface_consultorio.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Consultorios." + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de un Consultorio
         **/
        public bool ModificarConsultorio(int id, int numero, string nombre, int piso)
        {
            try
            {
                return interface_consultorio.modificar(
                    new Consultorio
                    {
                        Id = id,
                        Numero = numero,
                        Nombre = nombre,
                        Piso= piso
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Consultorio: " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de un Consultorio
         **/
        public bool EliminarConsultorio(int id)
        {
            try
            {

                return interface_consultorio.eliminar(
                    new Consultorio
                    {
                        Id = id,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Consultorio: " + e.Message);

            }
        }
    }
}
