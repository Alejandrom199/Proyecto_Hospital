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

namespace CapaPresentacion.Paciente
{
    public partial class AgregarPacienteView : Form
    {
        private PacienteController controller = new PacienteController();
        public AgregarPacienteView()
        {
            InitializeComponent();
        }

        private void setearCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxCedula.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            cbxSexo.Text = string.Empty;
            tbxDireccion.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            tbxEmail.Text = string.Empty;
        }

        private void btnAgregarPaciente_Click(object sender, EventArgs e)
        {
            if (tbxNombre.Text!="" && tbxApellidos.Text!="" && tbxCedula.Text != "" && dtpFechaNacimiento.Text != "" && cbxSexo.Text != "" && tbxDireccion.Text != "" && tbxTelefono.Text != "" && tbxEmail.Text != "")
            {
                try
                {
                    string nombre = tbxNombre.Text;
                    string apellido = tbxApellidos.Text;
                    string cedula = tbxCedula.Text;
                    DateTime fecha_nacimiento = dtpFechaNacimiento.Value;
                    string sexo = cbxSexo.Text;
                    string direccion = tbxDireccion.Text;
                    string telefono = tbxTelefono.Text;
                    string email = tbxEmail.Text;
                    DateTime fecha_registro = DateTime.Now;

                    var resultado = controller.AgregarPaciente(nombre, apellido, cedula, fecha_nacimiento, sexo, direccion, telefono, email, fecha_registro);

                    if (resultado)
                    {
                        MessageBox.Show("Registro de Paciente creado con Éxito.");
                    }
                }
                catch (Exception ex)
                {
                }
            }
            else
            {
                MessageBox.Show("Rellene todos los datos del Paciente");
            }
        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            setearCampos();
        }
    }
}
