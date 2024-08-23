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
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.Design.AxImporter;

namespace CapaPresentacion.Paciente
{
    public partial class ModificarPacienteView : Form
    {
        private PacienteController controller;
        private bool estaEncontrado = false;
        public ModificarPacienteView()
        {
            InitializeComponent();
            controller = new PacienteController();
        }

        private void ModificarPacienteView_Load(object sender, EventArgs e)
        {
            habilitarCampos(false);
        }

        private void habilitarCampos(bool opcion)
        {
            tbxNombre.Enabled = opcion;
            tbxApellidos.Enabled = opcion;
            tbxCedula.Enabled = opcion;
            dtpFechaNacimiento.Enabled = opcion;
            cbxSexo.Enabled = opcion;
            tbxDireccion.Enabled = opcion;
            tbxTelefono.Enabled = opcion;
            tbxEmail.Enabled = opcion;
            dtpFechaRegistro.Enabled = opcion;
            btnModificarPaciente.Enabled = opcion;
            btnBorrarCampos.Enabled = opcion;
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
            dtpFechaRegistro.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!tbxId.Text.Equals(""))
            {
                Dictionary<string, object> pacienteInfo = controller.GetPacientePorId(Int32.Parse(tbxId.Text));

                try
                {
                    tbxNombre.Text = pacienteInfo["Nombre"].ToString();
                    tbxApellidos.Text = pacienteInfo["Apellido"].ToString();
                    tbxCedula.Text = pacienteInfo["Cedula"].ToString();
                    dtpFechaNacimiento.Value = Convert.ToDateTime(pacienteInfo["FechaNacimiento"]);
                    cbxSexo.Text = pacienteInfo["Sexo"].ToString();
                    tbxDireccion.Text = pacienteInfo["Direccion"].ToString();
                    tbxTelefono.Text = pacienteInfo["Telefono"].ToString();
                    tbxEmail.Text = pacienteInfo["Email"].ToString();
                    dtpFechaRegistro.Value = Convert.ToDateTime(pacienteInfo["FechaRegistro"]);

                    habilitarCampos(true);
                    estaEncontrado = true;
                    tbxId.ReadOnly = true;
                    btnBuscar.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID no registrado como Paciente");
                    setearCampos();
                    habilitarCampos(false);
                    estaEncontrado = false;
                }
            }
        }

        private void btnBorrarCampos_Click(object sender, EventArgs e)
        {
            setearCampos();
            habilitarCampos(false);
            tbxId.ReadOnly = false;
            btnBuscar.Enabled = true;
        }

        private void btnModificarPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                if (estaEncontrado)
                {
                    int id = Int32.Parse(tbxId.Text);
                    string nombre = tbxNombre.Text;
                    string apellido = tbxApellidos.Text;
                    string cedula = tbxCedula.Text;
                    DateTime fecha_nacimiento = dtpFechaNacimiento.Value;
                    string sexo = cbxSexo.Text;
                    string direccion = tbxDireccion.Text;
                    string telefono = tbxTelefono.Text;
                    string email = tbxEmail.Text;
                    DateTime fecha_registro = DateTime.Now;

                    var resultado = controller.ModificarPaciente(id,nombre, apellido, cedula, fecha_nacimiento, sexo, direccion, telefono, email, fecha_registro);

                    if (resultado)
                    {
                        MessageBox.Show("Modificación de Paciente realizada con Éxito.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Rellene todos los datos del Paciente");
            }
        }
    }
}
