using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Proveedor
    {
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;
        private string email;
        private string nombre_de_contacto;

        public Proveedor(int id, string nombre, string direccion, string telefono, string email, string nombre_de_contacto)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.email = email;
            this.nombre_de_contacto = nombre_de_contacto;
        }

        public Proveedor()
        {
            id = 0;
            nombre = string.Empty;
            direccion = string.Empty;
            telefono = string.Empty;
            email = string.Empty;
            nombre_de_contacto = string.Empty;
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

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string NombreDeContacto
        {
            get { return nombre_de_contacto; }
            set { nombre_de_contacto = value; }
        }
    }
}
