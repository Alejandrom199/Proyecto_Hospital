using CapaNegocio.Controllers;
using CapaPresentacion.Medicamento.Complementos_Medicamentos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Medicamento
{
    public partial class AgregarMedicamento : Form
    {
        MedicamentoController controller;
        public AgregarMedicamento()
        {
            InitializeComponent();
            controller = new MedicamentoController();
        }
        private void setearCampos()
        {
            tbxNombreComercial.Text = string.Empty;
            tbxNombreGenerico.Text = string.Empty;
            cbxPresentacion.Text = string.Empty;
            tbxDosis.Text = string.Empty;
            dtpFechaExpiracion.Text = string.Empty;
            tbxLote.Text = string.Empty;
            nudPrecio.Text = string.Empty;
            cbxProveedor.Text = string.Empty;
            rtbIndicaciones.Text = string.Empty;
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {
            if (tbxNombreComercial.Text != "" && tbxNombreGenerico.Text != "" && cbxPresentacion.Text != "" && tbxDosis.Text != "" && dtpFechaExpiracion.Text != "" && tbxLote.Text != "" && nudPrecio.Value != 0 && cbxProveedor.Text != "" && rtbIndicaciones.Text != "")
            {
                try
                {
                    string nombre_comercial = tbxNombreComercial.Text;
                    string nombre_generico = tbxNombreGenerico.Text;
                    int presentacion_id = controller.ObtenerIdPresentacionParaMedicamento(cbxPresentacion.Text);
                    string dosis = tbxDosis.Text;
                    DateTime fecha_expiracion = dtpFechaExpiracion.Value;
                    string lote = tbxLote.Text;
                    decimal precio = nudPrecio.Value;
                    int proveedor_id = controller.ObtenerIdProveedorParaMedicamento(cbxProveedor.Text);
                    string indicaciones = rtbIndicaciones.Text;

                    var resultado = controller.AgregarMedicamento(nombre_comercial, nombre_generico, presentacion_id, dosis, fecha_expiracion, lote, precio, proveedor_id, indicaciones);

                    if (resultado)
                    {
                        MessageBox.Show("Registro de Medicamento creado con Éxito.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los datos del Medicamento");
            }
        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            new ProveedorView().Show();
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            new PresentacionView().Show();
        }

        private void CargarDatosComboBoxPresentaciones()
        {
            Dictionary<int, string> presentaciones = controller.ObtenerPresentacionesParaMedicamento();

            foreach (KeyValuePair<int, string> presentacion in presentaciones)
            {
                cbxPresentacion.Items.Add(presentacion.Value);
            }

        }

        private void CargarDatosComboBoxProveedores()
        {
            Dictionary<int, string> proveedores = controller.ObtenerProveedoresParaMedicamento();

            foreach (KeyValuePair<int, string> proveedor in proveedores)
            {
                cbxProveedor.Items.Add(proveedor.Value);
            }
        }

        private void AgregarMedicamento_Load(object sender, EventArgs e)
        {
            CargarDatosComboBoxPresentaciones();
            CargarDatosComboBoxProveedores();
        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            setearCampos();
        }
    }
}
