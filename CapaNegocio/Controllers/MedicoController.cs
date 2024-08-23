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
    public class MedicoController
    {
        private IMedico interface_medico = new MedicoService();
        /**
        * Método para obtener la lista de las Medicos
        **/
        public DataTable GetListaMedicos()
        {
            Console.WriteLine("entro al lista Medicos");
            try
            {
                //De está manera la lógica disminuye en capa Negocio
                return interface_medico.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Medicos." + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los nombres de Especialidades
        **/
        public Dictionary<int, string> ObtenerEspecialidadesParaMedico()
        {
            try
            {
                return interface_medico.ObtenerEspecialidadesParaMedico();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Especialidades." + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los nombres de Consultorios
        **/
        public Dictionary<int, string> ObtenerConsultoriosParaMedico()
        {
            try
            {
                return interface_medico.ObtenerConsultoriosParaMedico();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Consultorios." + e.Message);
            }
        }

        /**
        * Método para obtener la lista de las horas de Horarios
        **/
        public Dictionary<int, string> ObtenerHorariosParaMedico()
        {
            try
            {
                return interface_medico.ObtenerHorariosParaMedico();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener los nombres de Consultorios." + e.Message);
            }
        }
    }
}
