namespace CapaPresentacion.Paciente
{
    partial class ModificarPacienteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarPacienteView));
            pictureBox1 = new PictureBox();
            btnBorrarCampos = new Button();
            btnModificarPaciente = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            cbxSexo = new ComboBox();
            tbxEmail = new TextBox();
            tbxTelefono = new TextBox();
            tbxDireccion = new TextBox();
            tbxCedula = new TextBox();
            tbxApellidos = new TextBox();
            tbxNombre = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label9 = new Label();
            tbxId = new TextBox();
            label10 = new Label();
            dtpFechaRegistro = new DateTimePicker();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 42;
            pictureBox1.TabStop = false;
            // 
            // btnBorrarCampos
            // 
            btnBorrarCampos.BackColor = SystemColors.Highlight;
            btnBorrarCampos.FlatStyle = FlatStyle.Flat;
            btnBorrarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarCampos.ForeColor = SystemColors.ControlLightLight;
            btnBorrarCampos.Location = new Point(308, 518);
            btnBorrarCampos.Name = "btnBorrarCampos";
            btnBorrarCampos.Size = new Size(239, 40);
            btnBorrarCampos.TabIndex = 41;
            btnBorrarCampos.Text = "Modificar otro Paciente";
            btnBorrarCampos.UseVisualStyleBackColor = false;
            btnBorrarCampos.Click += btnBorrarCampos_Click;
            // 
            // btnModificarPaciente
            // 
            btnModificarPaciente.BackColor = SystemColors.Highlight;
            btnModificarPaciente.FlatStyle = FlatStyle.Flat;
            btnModificarPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnModificarPaciente.Location = new Point(99, 518);
            btnModificarPaciente.Name = "btnModificarPaciente";
            btnModificarPaciente.Size = new Size(190, 40);
            btnModificarPaciente.TabIndex = 40;
            btnModificarPaciente.Text = "Modificar Paciente";
            btnModificarPaciente.UseVisualStyleBackColor = false;
            btnModificarPaciente.Click += btnModificarPaciente_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(256, 260);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(333, 31);
            dtpFechaNacimiento.TabIndex = 39;
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "MASCULINO", "FEMENINO" });
            cbxSexo.Location = new Point(312, 300);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(277, 33);
            cbxSexo.TabIndex = 38;
            // 
            // tbxEmail
            // 
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Location = new Point(184, 420);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(405, 31);
            tbxEmail.TabIndex = 37;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(312, 380);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(277, 31);
            tbxTelefono.TabIndex = 36;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(166, 340);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(423, 31);
            tbxDireccion.TabIndex = 35;
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(312, 220);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(277, 31);
            tbxCedula.TabIndex = 34;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(312, 180);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.Size = new Size(277, 31);
            tbxApellidos.TabIndex = 33;
            // 
            // tbxNombre
            // 
            tbxNombre.ForeColor = SystemColors.WindowText;
            tbxNombre.Location = new Point(312, 140);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(277, 31);
            tbxNombre.TabIndex = 32;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(206, 30);
            label12.Name = "label12";
            label12.Size = new Size(282, 32);
            label12.TabIndex = 31;
            label12.Text = "MODIFICAR PACIENTES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 420);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 30;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 380);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 29;
            label7.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 340);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 28;
            label6.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 300);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 27;
            label5.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 260);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 26;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 220);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 25;
            label3.Text = "Cédula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 180);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 24;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 140);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 23;
            label1.Text = "Nombre: ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 100);
            label9.Name = "label9";
            label9.Size = new Size(34, 25);
            label9.TabIndex = 43;
            label9.Text = "ID:";
            // 
            // tbxId
            // 
            tbxId.Location = new Point(312, 97);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(150, 31);
            tbxId.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(74, 460);
            label10.Name = "label10";
            label10.Size = new Size(156, 25);
            label10.TabIndex = 45;
            label10.Text = "Fecha de Registro:";
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(256, 460);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(333, 31);
            dtpFechaRegistro.TabIndex = 46;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(477, 94);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 47;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // ModificarPacienteView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(btnBuscar);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(label10);
            Controls.Add(tbxId);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrarCampos);
            Controls.Add(btnModificarPaciente);
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
            Name = "ModificarPacienteView";
            Text = "ModificarPacienteView";
            Load += ModificarPacienteView_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnBorrarCampos;
        private Button btnModificarPaciente;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cbxSexo;
        private TextBox tbxEmail;
        private TextBox tbxTelefono;
        private TextBox tbxDireccion;
        private TextBox tbxCedula;
        private TextBox tbxApellidos;
        private TextBox tbxNombre;
        private Label label12;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label9;
        private TextBox tbxId;
        private Label label10;
        private DateTimePicker dtpFechaRegistro;
        private Button btnBuscar;
    }
}