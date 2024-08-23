using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaServicios.Interfaces
{
    public interface IGestionEntidades<T>
    {
        bool agregar(T entidad);

        bool modificar(T entidad);

        DataTable listar();

        bool eliminar(T entidad);
    }
}
