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
    public partial class ListarPacienteView : Form
    {
        private PacienteController controller;
        public ListarPacienteView()
        {
            InitializeComponent();
            controller = new PacienteController();

            ComponenteValor(null, false);
        }

        private void PacienteView_Load(object sender, EventArgs e)
        {
            FiltrarTodosRegistros();
        }

        private void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxFiltro.Text.Equals("Id"))
                {
                    FiltrarPorId();
                }
                else if (cbxFiltro.Text.Equals("Nombre"))
                {
                    FiltrarPorNombre();
                }
                else if (cbxFiltro.Text.Equals("Apellido"))
                {
                    FiltrarPorApellido();
                }
                else if (cbxFiltro.Text.Equals("Cedula"))
                {
                    FiltrarPorCedula();
                }
                else
                {
                    FiltrarTodosRegistros();
                }

                tbxValor.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FiltrarTodosRegistros()
        {
            try
            {
                dgvPacientes.AllowUserToAddRows = false;
                dgvPacientes.DataSource = controller.GetListaPacientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FiltrarPorId()
        {
            if (tbxValor.Text != "")
            {
                int id;
                bool esEntero = int.TryParse(tbxValor.Text, out id);

                if (esEntero)
                {
                    dgvPacientes.AllowUserToAddRows = false;
                    dgvPacientes.DataSource = controller.FiltrarListaPacientesPorId(id);
                }
                else
                {
                    MessageBox.Show("Ingrese un valor entero válido.");
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor en el campo id.");
            }
        }

        private void FiltrarPorNombre()
        {

            if (tbxValor.Text != "")
            {
                string nombre = tbxValor.Text.Trim();
                if (nombre.Length <= 25)
                {
                    dgvPacientes.AllowUserToAddRows = false;
                    dgvPacientes.DataSource = controller.FiltrarListaPacientesPorNombre(nombre);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor en el campo nombre.");
            }
        }

        private void FiltrarPorApellido()
        {
            if (tbxValor.Text != "")
            {
                string apellido = tbxValor.Text;
                if (apellido.Length <= 50)
                {
                    dgvPacientes.AllowUserToAddRows = false;
                    dgvPacientes.DataSource = controller.FiltrarListaPacientesPorApellido(apellido);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor en el campo apellido.");
            }
        }

        private void FiltrarPorCedula()
        {
            if (tbxValor.Text != "")
            {
                string cedula = tbxValor.Text;
                if (cedula.Length <= 10)
                {
                    dgvPacientes.AllowUserToAddRows = false;
                    dgvPacientes.DataSource = controller.FiltrarListaPacientesPorCedula(cedula);
                }
            }
            else
            {
                MessageBox.Show("Ingrese un valor en el campo cédula.");
            }
        }

        private void cbxFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cbxFiltro.Text.Equals("Id"))
                {
                    ComponenteValor("Id:", true);
                }
                else if (cbxFiltro.Text.Equals("Nombre"))
                {
                    ComponenteValor("Nombre:", true);
                }
                else if (cbxFiltro.Text.Equals("Apellido"))
                {
                    ComponenteValor("Apellido:", true);
                }
                else if (cbxFiltro.Text.Equals("Cedula"))
                {
                    ComponenteValor("Cédula:", true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ComponenteValor(string campo, bool activar)
        {
            lblValor.Text = campo;
            lblValor.Visible = activar;
            tbxValor.Visible = activar;
            btnBuscarPaciente.Visible = activar;
        }

        private void dgvPacientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
