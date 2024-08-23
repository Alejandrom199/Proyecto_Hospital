using CapaDatos.Entidades;
using CapaPersistencia;
using CapaServicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Servicios
{
    public class MedicamentoService : IMedicamento
    {
        private ManageSQL manejo_sql = new ManageSQL();
        public bool agregar(Medicamento entidad)
        {
            throw new NotImplementedException();
        }

        public bool eliminar(Medicamento entidad)
        {
            throw new NotImplementedException();
        }

        public DataTable listar()
        {
            Console.WriteLine("entro a la lista de Medicamentos");
            try
            {
                string nombreStoredProcedure = "SP_OBTENER_MEDICAMENTOS";
                return manejo_sql.EjecutarSPSelect(nombreStoredProcedure, null);
            }
            catch (Exception e)
            {
                throw new Exception("Error al obtener listado de Medicamentos." + e.Message);
            }
        }

        public bool modificar(Medicamento entidad)
        {
            throw new NotImplementedException();
        }
    }
}
