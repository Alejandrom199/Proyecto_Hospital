namespace CapaPresentacion.Paciente
{
    partial class AgregarPacienteView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarPacienteView));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label12 = new Label();
            tbxNombre = new TextBox();
            tbxApellidos = new TextBox();
            tbxCedula = new TextBox();
            tbxDireccion = new TextBox();
            tbxTelefono = new TextBox();
            tbxEmail = new TextBox();
            cbxSexo = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            btnAgregarPaciente = new Button();
            btnBorrarCampos = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 110);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 1;
            label2.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 160);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 2;
            label3.Text = "Cédula:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 210);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 3;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 260);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 4;
            label5.Text = "Sexo:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 310);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 5;
            label6.Text = "Dirección:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 360);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 6;
            label7.Text = "Telefono:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 410);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 7;
            label8.Text = "Email:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(206, 10);
            label12.Name = "label12";
            label12.Size = new Size(260, 32);
            label12.TabIndex = 11;
            label12.Text = "AGREGAR PACIENTES";
            // 
            // tbxNombre
            // 
            tbxNombre.ForeColor = SystemColors.WindowText;
            tbxNombre.Location = new Point(312, 60);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(277, 31);
            tbxNombre.TabIndex = 12;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(312, 110);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.Size = new Size(277, 31);
            tbxApellidos.TabIndex = 13;
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(312, 160);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(277, 31);
            tbxCedula.TabIndex = 14;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(166, 310);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(423, 31);
            tbxDireccion.TabIndex = 15;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(312, 360);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(277, 31);
            tbxTelefono.TabIndex = 16;
            // 
            // tbxEmail
            // 
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Location = new Point(166, 410);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(423, 31);
            tbxEmail.TabIndex = 17;
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "MASCULINO", "FEMENINO" });
            cbxSexo.Location = new Point(312, 260);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(277, 33);
            cbxSexo.TabIndex = 18;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(256, 210);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(333, 31);
            dtpFechaNacimiento.TabIndex = 19;
            // 
            // btnAgregarPaciente
            // 
            btnAgregarPaciente.BackColor = SystemColors.Highlight;
            btnAgregarPaciente.FlatStyle = FlatStyle.Flat;
            btnAgregarPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnAgregarPaciente.Location = new Point(135, 519);
            btnAgregarPaciente.Name = "btnAgregarPaciente";
            btnAgregarPaciente.Size = new Size(190, 40);
            btnAgregarPaciente.TabIndex = 20;
            btnAgregarPaciente.Text = "Agregar Paciente";
            btnAgregarPaciente.UseVisualStyleBackColor = false;
            btnAgregarPaciente.Click += btnAgregarPaciente_Click;
            // 
            // btnBorrarCampos
            // 
            btnBorrarCampos.BackColor = SystemColors.Highlight;
            btnBorrarCampos.FlatStyle = FlatStyle.Flat;
            btnBorrarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarCampos.ForeColor = SystemColors.ControlLightLight;
            btnBorrarCampos.Location = new Point(344, 519);
            btnBorrarCampos.Name = "btnBorrarCampos";
            btnBorrarCampos.Size = new Size(182, 40);
            btnBorrarCampos.TabIndex = 21;
            btnBorrarCampos.Text = "Borrar Campos";
            btnBorrarCampos.UseVisualStyleBackColor = false;
            btnBorrarCampos.Click += btnBorrarCampos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // AgregarPacienteView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrarCampos);
            Controls.Add(btnAgregarPaciente);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cbxSexo);
            Controls.Add(tbxEmail);
            Controls.Add(tbxTelefono);
            Controls.Add(tbxDireccion);
            Controls.Add(tbxCedula);
            Controls.Add(tbxApellidos);
            Controls.Add(tbxNombre);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarPacienteView";
            Text = "AgregarPacienteView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label12;
        private TextBox tbxNombre;
        private TextBox tbxApellidos;
        private TextBox tbxCedula;
        private TextBox tbxDireccion;
        private TextBox tbxTelefono;
        private TextBox tbxEmail;
        private ComboBox cbxSexo;
        private DateTimePicker dtpFechaNacimiento;
        private Button btnAgregarPaciente;
        private Button btnBorrarCampos;
        private PictureBox pictureBox1;
    }
}