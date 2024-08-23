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

namespace CapaPresentacion
{
    public partial class FacturacionView : Form
    {
        private FacturacionController controller;
        public FacturacionView()
        {
            InitializeComponent();
            controller = new FacturacionController();
        }

        private void FacturacionView_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMedicamentos.AllowUserToAddRows = false;
                dgvMedicamentos.DataSource = controller.GetListaFacturaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
