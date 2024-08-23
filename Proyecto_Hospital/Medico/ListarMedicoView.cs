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
    public partial class ListarMedicoView : Form
    {
        private MedicoController controller;
        public ListarMedicoView()
        {
            InitializeComponent();
            controller = new MedicoController();
        }

        private void dgvMedicos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MedicoView_Load(object sender, EventArgs e)
        {
            try
            {
                dgvMedicos.AllowUserToAddRows = false;
                dgvMedicos.DataSource = controller.GetListaMedicos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
