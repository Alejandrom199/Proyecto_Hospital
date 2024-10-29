using CapaNegocio.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Facturacion
{
    public partial class AnadirMedicamentosAFacturaView : Form
    {
        FacturacionController controller;
        FacturaMedicamentoController controller2;
        AgregarFacturacionView agregarFacturacionView;
        private int facturaIdGenerada;


        public AnadirMedicamentosAFacturaView(int facturaIdGenerada)
        {
            InitializeComponent();
            this.facturaIdGenerada = facturaIdGenerada;
            MessageBox.Show(facturaIdGenerada.ToString());
            controller = new FacturacionController();
            controller2 = new FacturaMedicamentoController();
            agregarFacturacionView = new AgregarFacturacionView();
        }

        /**
         * Método para actualizar el DataGridView
         **/
        private void CargarGridMedicamentosFacturas()
        {
            try
            {
                dgvMedimentosFactura2.AllowUserToAddRows = false;
                dgvMedimentosFactura2.DataSource = controller2.GetListaFacturaMedicamento(facturaIdGenerada);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void AnadirMedicamentosAFacturaView_Load(object sender, EventArgs e)
        {
            CargarGridMedicamentosFacturas();
            CargarDatosComboBoxMedicamentos();
        }

        private void CargarDatosComboBoxMedicamentos()
        {
            Dictionary<int, string> medicamentos = controller.ObtenerMedicamentosParaFacturacion();

            foreach (KeyValuePair<int, string> medicamento in medicamentos)
            {
                cbxMedicamentos.Items.Add(medicamento.Value);
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            agregarFacturacionView.HabilitarButtonCrearFactura();
            Close();
        }


        /*AQUI ESTA EL PROBLEMA AL OBTENER EL MONTO TOTAl*/

        private void btnAgregarAFactura_Click(object sender, EventArgs e)
        {
            if (cbxMedicamentos.Text != "" && tbxCantidad.Text != "")
            {

                try
                {
                    int medicamento_id = controller2.ObtenerIdMedicamentoParaFacturacionMedicamento(cbxMedicamentos.Text);
                    int cantidad = Convert.ToInt32(tbxCantidad.Text);

                    var resultado = controller2.AgregarFacturaMedicamento(facturaIdGenerada, medicamento_id, cantidad);

                    if (resultado)
                    {
                        CargarGridMedicamentosFacturas();
                        MessageBox.Show("Entro por true");
                        //decimal monto_total = controller.ObtenerMontoTotal(facturaIdGenerada);
                        //MessageBox.Show(monto_total.ToString());
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
    }
}
