using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.Entidades
{
    public class Medicamento
    {
        private int id_medicamento;
        private string nombre_comercial;
        private string nombre_generico;
        private int presentacion_id;
        private string dosis;
        private DateTime fecha_expiracion;
        private string lote;
        private decimal precio;
        private int proveedor_id;
        private string indicaciones;

        // Constructor parametrizado
        public Medicamento(int id_medicamento, string nombre_comercial, string nombre_generico, int presentacion_id, string dosis, DateTime fecha_expiracion, string lote, decimal precio, int proveedor_id, string indicaciones)
        {
            this.id_medicamento = id_medicamento;
            this.nombre_comercial = nombre_comercial;
            this.nombre_generico = nombre_generico;
            this.presentacion_id = presentacion_id;
            this.dosis = dosis;
            this.fecha_expiracion = fecha_expiracion;
            this.lote = lote;
            this.precio = precio;
            this.proveedor_id = proveedor_id;
            this.indicaciones = indicaciones;
        }

        // Constructor por defecto
        public Medicamento()
        {
            id_medicamento = 0;
            nombre_comercial = string.Empty;
            nombre_generico = string.Empty;
            presentacion_id = 0;
            dosis = string.Empty;
            fecha_expiracion = DateTime.Now;
            lote = string.Empty;
            precio = 0;
            proveedor_id = 0;
            indicaciones = string.Empty;
        }

        // Propiedades
        public int IdMedicamento
        {
            get { return id_medicamento; }
            set { id_medicamento = value; }
        }

        public string NombreComercial
        {
            get { return nombre_comercial; }
            set { nombre_comercial = value; }
        }

        public string NombreGenerico
        {
            get { return nombre_generico; }
            set { nombre_generico = value; }
        }

        public int PresentacionId
        {
            get { return presentacion_id; }
            set { presentacion_id = value; }
        }

        public string Dosis
        {
            get { return dosis; }
            set { dosis = value; }
        }

        public DateTime FechaExpiracion
        {
            get { return fecha_expiracion; }
            set { fecha_expiracion = value; }
        }

        public string Lote
        {
            get { return lote; }
            set { lote = value; }
        }

        public decimal Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public int ProveedorId
        {
            get { return proveedor_id; }
            set { proveedor_id = value; }
        }

        public string Indicaciones
        {
            get { return indicaciones; }
            set { indicaciones = value; }
        }
    }
}
