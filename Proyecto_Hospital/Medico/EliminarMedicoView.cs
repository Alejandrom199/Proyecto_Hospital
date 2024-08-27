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

namespace CapaPresentacion.Medico.Complementos_Medico
{
    public partial class EliminarMedicoView : Form
    {
        private MedicoController controller;
        private bool estaEncontrado = false;

        public EliminarMedicoView()
        {
            InitializeComponent();
            controller = new MedicoController();

            btnEliminarMedico.Enabled = false;
            habilitarCampos(false);
        }

        private void habilitarCampos(bool opcion)
        {
            tbxNombre.Enabled = opcion;
            tbxApellidos.Enabled = opcion;
            tbxCedula.Enabled = opcion;
            dtpFechaNacimiento.Enabled = opcion;
            cbxEspecialidad.Enabled = opcion;
            tbxNumeroLicencia.Enabled = opcion;
            cbxSexo.Enabled = opcion;
            tbxTelefono.Enabled = opcion;
            tbxEmail.Enabled = opcion;
            cbxHorario.Enabled = opcion;
            cbxConsultorio.Enabled = opcion;
        }
        private void setearCampos()
        {
            tbxNombre.Text = string.Empty;
            tbxApellidos.Text = string.Empty;
            tbxCedula.Text = string.Empty;
            dtpFechaNacimiento.Value = DateTime.Now;
            cbxEspecialidad.Text = string.Empty;
            tbxNumeroLicencia.Text = string.Empty;
            cbxSexo.Text = string.Empty;
            tbxTelefono.Text = string.Empty;
            tbxEmail.Text = string.Empty;
            cbxHorario.Text = string.Empty;
            cbxConsultorio.Text = string.Empty;
        }

        private void btnEliminarMedico_Click(object sender, EventArgs e)
        {
            if (estaEncontrado)
            {
                int id = Int32.Parse(tbxId.Text);

                try
                {
                    DialogResult resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar el Médico?", "Eliminar Médico", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (resultado == DialogResult.Yes)
                    {
                        if (controller.EliminarMedico(id))
                        {
                            MessageBox.Show("Eliminación de Médico realizada con Éxito.");
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!tbxId.Text.Equals(""))
            {
                int idMedico = Convert.ToInt32(tbxId.Text);
                Dictionary<string, object> medicoInfo = controller.GetMedicoPorId(idMedico);
                try
                {

                    tbxNombre.Text = medicoInfo["Nombre"].ToString();
                    tbxApellidos.Text = medicoInfo["Apellido"].ToString();
                    tbxCedula.Text = medicoInfo["Cedula"].ToString();
                    dtpFechaNacimiento.Value = Convert.ToDateTime(medicoInfo["FechaNacimiento"]);

                    cbxEspecialidad.Text = controller.ObtenerNombreEspecialidadMedianteIdMedico(idMedico);
                    tbxNumeroLicencia.Text = medicoInfo["NumeroLicencia"].ToString();
                    cbxSexo.Text = medicoInfo["Sexo"].ToString();
                    tbxTelefono.Text = medicoInfo["Telefono"].ToString();
                    tbxEmail.Text = medicoInfo["Email"].ToString();
                    cbxHorario.Text = controller.ObtenerHorarioMedianteIdMedico(idMedico);
                    cbxConsultorio.Text = controller.ObtenerNombreConsultorioMedianteIdMedico(idMedico);

                    btnEliminarMedico.Enabled = true;
                    estaEncontrado = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ID no registrado como Médico");
                    estaEncontrado = false;
                    btnEliminarMedico.Enabled = false;
                }
            }
        }
    }
}
