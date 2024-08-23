using CapaDatos.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Interfaces
{
    public interface IMedico : IGestionEntidades<Medico>
    {
        DataTable buscar_por_especialidad(string especialidad);

        Dictionary<int, string> ObtenerEspecialidadesParaMedico();

        Dictionary<int, string> ObtenerConsultoriosParaMedico();

        Dictionary<int, string> ObtenerHorariosParaMedico();
    }
}
