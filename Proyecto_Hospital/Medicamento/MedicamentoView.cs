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
    public partial class MedicamentoView : Form
    {
        private MedicamentoController controller;
        public MedicamentoView()
        {
            InitializeComponent();
            controller = new MedicamentoController();
        }

        private void MedicamentoView_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMedicamentos.AllowUserToAddRows = false;
                dgvMedicamentos.DataSource = controller.GetListaMedicamentos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
