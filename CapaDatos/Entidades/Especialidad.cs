using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Especialidad
    {
        private int id;
        private string nombre;

        public Especialidad(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Especialidad()
        {
            id = 0;
            nombre = string.Empty;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
    }
}
