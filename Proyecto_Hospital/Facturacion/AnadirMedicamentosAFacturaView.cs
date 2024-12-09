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
        private decimal monto_total = 0;


        public AnadirMedicamentosAFacturaView(int facturaIdGenerada)
        {
            InitializeComponent();
            this.facturaIdGenerada = facturaIdGenerada;
            controller = new FacturacionController();
            controller2 = new FacturaMedicamentoController();
            agregarFacturacionView = new AgregarFacturacionView();
            tbxCantidad.Text = "0";
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
            monto_total = controller2.GetValorMontoTotal(facturaIdGenerada);
            Close();
        }


        private void btnAgregarAFactura_Click(object sender, EventArgs e)
        {
            if (cbxMedicamentos.Text != "" && tbxCantidad.Text != "")
            {

                try
                {
                    int medicamento_id = controller2.ObtenerIdMedicamentoParaFacturacionMedicamento(cbxMedicamentos.Text);
                    int cantidad = Convert.ToInt32(tbxCantidad.Text);

                    if (cantidad > 0)
                    {
                        var resultado = controller2.AgregarFacturaMedicamento(facturaIdGenerada, medicamento_id, cantidad);

                        if (resultado)
                        {
                            tbxCantidad.Text = "0";
                            CargarGridMedicamentosFacturas();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese una cantidad mayor(>) a 0.");
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
