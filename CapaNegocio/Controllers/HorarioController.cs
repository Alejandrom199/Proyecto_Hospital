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
    public class HorarioController
    {
        private IHorario interface_horario = new HorarioService();

        /**
         * Método para realizar una inserción de una Horario
         **/
        public bool AgregarHorario(TimeSpan horaInicio, TimeSpan horaFin, string diaInicio, string diaFin)
        {
            try
            {
                return interface_horario.agregar(
                    new Horario
                    {
                        HoraInicio = horaInicio,
                        HoraFin = horaFin,
                        DiaInicio = diaInicio,
                        DiaFin = diaFin
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al crear Horario: " + e.Message);
            }
        }

        /**
        * Método para obtener la lista de los Horarios
        **/
        public DataTable GetListaHorarios()
        {
            try
            {
                return interface_horario.listar();
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Horarios." + e.Message);
            }
        }

        /**
         * Método para realizar una modificación de un Horario
         **/
        public bool ModificarHorario(int id, TimeSpan horaInicio, TimeSpan horaFin, string diaInicio, string diaFin)
        {
            try
            {
                return interface_horario.modificar(
                    new Horario
                    {
                        Id = id,
                        HoraInicio = horaInicio,
                        HoraFin = horaFin,
                        DiaInicio = diaInicio,
                        DiaFin = diaFin
                    }
                );
            }
            catch (Exception e)
            {
                
                throw new Exception("Error al modificar Horario: " + e.Message);
            }
        }

        /**
         * Método para realizar una eliminación de un Horario
         **/
        public bool EliminarHorario(int id)
        {
            try
            {
                return interface_horario.eliminar(
                    new Horario
                    {
                        Id = id,
                    }
                );
            }
            catch (Exception e)
            {
                throw new Exception("Error al eliminar Horario: " + e.Message);

            }
        }
    }
}
