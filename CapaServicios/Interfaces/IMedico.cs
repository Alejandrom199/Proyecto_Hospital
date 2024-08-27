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
        Dictionary<string, object> buscar_por_ID(int id);
        DataTable buscar_por_especialidad(string especialidad);

        Dictionary<int, string> ObtenerEspecialidadesParaMedico();

        Dictionary<int, string> ObtenerConsultoriosParaMedico();

        Dictionary<int, string> ObtenerHorariosParaMedico();

        int ObtenerIdEspecialidadParaMedico(string nombre);

        int ObtenerIdConsultorioParaMedico(string nombre);

        int ObtenerIdHorarioParaMedico(TimeSpan horaInicio, TimeSpan horaFin);

        string ObtenerEspecialidadMedianteIdMedico(int id);

        string ObtenerConsultorioMedianteIdMedico(int id);

        string ObtenerHorarioMedianteIdMedico(int id);
    }
}
