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
    public class EspecialidadController
    {
        private IEspecialidad interface_especialidad = new EspecialidadService();

        /**
         * Método para realizar una inserción de una Especialidad
         **/
        public bool AgregarEspecializacion(string nombre)
        {
            try
            {
                return interface_especialidad.agregar(
                    new Especialidad
                    {
                        Nombre = nombre
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Especialidad: " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las Especialidades
        **/
        public DataTable GetListaEspecialidades()
        {
            try
            {
                return interface_especialidad.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Especialidades." + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de una Especialidad
         **/
        public bool ModificarEspecialidad(int id, string nombre)
        {
            try
            {
                return interface_especialidad.modificar(
                    new Especialidad
                    {
                        Id = id,
                        Nombre = nombre,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al modificar Especialidad: " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de una Especialidad
         **/
        public bool EliminarEspecialidad(int id)
        {
            try
            {

                return interface_especialidad.eliminar(
                    new Especialidad
                    {
                        Id = id,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Especialidad: " + e.Message);

            }
        }
    }
}
