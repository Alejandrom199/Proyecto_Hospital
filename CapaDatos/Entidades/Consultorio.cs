using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Consultorio
    {
        private int id;
        private int numero;
        private string nombre;
        private int piso;

        public Consultorio(int id, int numero, string nombre, int piso)
        {
            this.id = id;
            this.numero = numero;
            this.nombre = nombre;
            this.piso = piso;
        }

        public Consultorio()
        {
            id = 0;
            numero = 0;
            nombre = string.Empty;
            piso = 0;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }
    }
}
