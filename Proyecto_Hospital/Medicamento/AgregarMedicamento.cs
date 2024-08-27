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
        public AgregarMedicamento()
        {
            InitializeComponent();
        }

        private void btnAgregarMedicamento_Click(object sender, EventArgs e)
        {

        }

        private void btnProveedor_Click(object sender, EventArgs e)
        {
            new ProveedorView().Show();
        }

        private void btnPresentacion_Click(object sender, EventArgs e)
        {
            new PresentacionView().Show();
        }
    }
}
