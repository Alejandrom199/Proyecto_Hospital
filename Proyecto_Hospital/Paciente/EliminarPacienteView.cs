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
    public partial class EliminarPacienteView : Form
    {
        private PacienteController controller;
        private bool estaEncontrado = false;
        public EliminarPacienteView()
        {
            InitializeComponent();
            controller = new PacienteController();

            btnEliminarPaciente.Enabled = false;
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

                    btnEliminarPaciente.Enabled = true;
                    estaEncontrado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID no registrado como Paciente: "+ex.Message);
                    estaEncontrado = false;
                    btnEliminarPaciente.Enabled = false;
                }
            }
        }

        private void btnEliminarPaciente_Click(object sender, EventArgs e)
        {
            if (estaEncontrado)
            {
                int id = Int32.Parse(tbxId.Text);

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el Paciente?", "Eliminar Paciente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        if (controller.EliminarPaciente(id))
                        {
                            MessageBox.Show("Eliminación de Paciente realizada con Éxito.");
                        }
                        else
                        {
                            MessageBox.Show("Registro no pudo ser eliminado!");
                        }
                    }
                    else if (resultado == DialogResult.No)
                    {

                    }


                }
                catch (Exception ex) { }
            }
        }
    }
}
