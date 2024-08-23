namespace CapaPresentacion.Paciente
{
    partial class EliminarPacienteView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EliminarPacienteView));
            tbxId = new TextBox();
            label9 = new Label();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            btnBuscar = new Button();
            dtpFechaRegistro = new DateTimePicker();
            label10 = new Label();
            btnEliminarPaciente = new Button();
            dtpFechaNacimiento = new DateTimePicker();
            cbxSexo = new ComboBox();
            tbxEmail = new TextBox();
            tbxTelefono = new TextBox();
            tbxDireccion = new TextBox();
            tbxCedula = new TextBox();
            tbxApellidos = new TextBox();
            tbxNombre = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbxId
            // 
            tbxId.Location = new Point(312, 97);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(150, 31);
            tbxId.TabIndex = 50;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 100);
            label9.Name = "label9";
            label9.Size = new Size(34, 25);
            label9.TabIndex = 49;
            label9.Text = "ID:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(206, 30);
            label12.Name = "label12";
            label12.Size = new Size(263, 32);
            label12.TabIndex = 48;
            label12.Text = "ELIMINAR PACIENTES";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 52;
            pictureBox1.TabStop = false;
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
            btnBuscar.TabIndex = 53;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // dtpFechaRegistro
            // 
            dtpFechaRegistro.Location = new Point(256, 460);
            dtpFechaRegistro.Name = "dtpFechaRegistro";
            dtpFechaRegistro.Size = new Size(333, 31);
            dtpFechaRegistro.TabIndex = 72;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(74, 460);
            label10.Name = "label10";
            label10.Size = new Size(156, 25);
            label10.TabIndex = 71;
            label10.Text = "Fecha de Registro:";
            // 
            // btnEliminarPaciente
            // 
            btnEliminarPaciente.BackColor = SystemColors.Highlight;
            btnEliminarPaciente.FlatStyle = FlatStyle.Flat;
            btnEliminarPaciente.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnEliminarPaciente.ForeColor = SystemColors.ControlLightLight;
            btnEliminarPaciente.Location = new Point(228, 518);
            btnEliminarPaciente.Name = "btnEliminarPaciente";
            btnEliminarPaciente.Size = new Size(190, 40);
            btnEliminarPaciente.TabIndex = 70;
            btnEliminarPaciente.Text = "Eliminar Paciente";
            btnEliminarPaciente.UseVisualStyleBackColor = false;
            btnEliminarPaciente.Click += btnEliminarPaciente_Click;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Location = new Point(256, 260);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(333, 31);
            dtpFechaNacimiento.TabIndex = 69;
            // 
            // cbxSexo
            // 
            cbxSexo.FormattingEnabled = true;
            cbxSexo.Items.AddRange(new object[] { "MASCULINO", "FEMENINO" });
            cbxSexo.Location = new Point(312, 300);
            cbxSexo.Name = "cbxSexo";
            cbxSexo.Size = new Size(277, 33);
            cbxSexo.TabIndex = 68;
            // 
            // tbxEmail
            // 
            tbxEmail.Cursor = Cursors.IBeam;
            tbxEmail.Location = new Point(184, 420);
            tbxEmail.Name = "tbxEmail";
            tbxEmail.Size = new Size(405, 31);
            tbxEmail.TabIndex = 67;
            // 
            // tbxTelefono
            // 
            tbxTelefono.Location = new Point(312, 380);
            tbxTelefono.Name = "tbxTelefono";
            tbxTelefono.Size = new Size(277, 31);
            tbxTelefono.TabIndex = 66;
            // 
            // tbxDireccion
            // 
            tbxDireccion.Location = new Point(166, 340);
            tbxDireccion.Name = "tbxDireccion";
            tbxDireccion.Size = new Size(423, 31);
            tbxDireccion.TabIndex = 65;
            // 
            // tbxCedula
            // 
            tbxCedula.Location = new Point(312, 220);
            tbxCedula.Name = "tbxCedula";
            tbxCedula.Size = new Size(277, 31);
            tbxCedula.TabIndex = 64;
            // 
            // tbxApellidos
            // 
            tbxApellidos.Location = new Point(312, 180);
            tbxApellidos.Name = "tbxApellidos";
            tbxApellidos.Size = new Size(277, 31);
            tbxApellidos.TabIndex = 63;
            // 
            // tbxNombre
            // 
            tbxNombre.ForeColor = SystemColors.WindowText;
            tbxNombre.Location = new Point(312, 140);
            tbxNombre.Name = "tbxNombre";
            tbxNombre.Size = new Size(277, 31);
            tbxNombre.TabIndex = 62;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 420);
            label8.Name = "label8";
            label8.Size = new Size(58, 25);
            label8.TabIndex = 61;
            label8.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 380);
            label7.Name = "label7";
            label7.Size = new Size(83, 25);
            label7.TabIndex = 60;
            label7.Text = "Telefono:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(70, 340);
            label6.Name = "label6";
            label6.Size = new Size(89, 25);
            label6.TabIndex = 59;
            label6.Text = "Dirección:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 300);
            label5.Name = "label5";
            label5.Size = new Size(54, 25);
            label5.TabIndex = 58;
            label5.Text = "Sexo:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 260);
            label4.Name = "label4";
            label4.Size = new Size(181, 25);
            label4.TabIndex = 57;
            label4.Text = "Fecha de Nacimiento:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 220);
            label3.Name = "label3";
            label3.Size = new Size(70, 25);
            label3.TabIndex = 56;
            label3.Text = "Cédula:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 180);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 55;
            label2.Text = "Apellidos:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 140);
            label1.Name = "label1";
            label1.Size = new Size(87, 25);
            label1.TabIndex = 54;
            label1.Text = "Nombre: ";
            // 
            // EliminarPacienteView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(dtpFechaRegistro);
            Controls.Add(label10);
            Controls.Add(btnEliminarPaciente);
            Controls.Add(dtpFechaNacimiento);
            Controls.Add(cbxSexo);
            Controls.Add(tbxEmail);
            Controls.Add(tbxTelefono);
            Controls.Add(tbxDireccion);
            Controls.Add(tbxCedula);
            Controls.Add(tbxApellidos);
            Controls.Add(tbxNombre);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnBuscar);
            Controls.Add(pictureBox1);
            Controls.Add(tbxId);
            Controls.Add(label9);
            Controls.Add(label12);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EliminarPacienteView";
            Text = "EliminarPacienteView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox tbxId;
        private Label label9;
        private Label label12;
        private PictureBox pictureBox1;
        private Button btnBuscar;
        private DateTimePicker dtpFechaRegistro;
        private Label label10;
        private Button btnEliminarPaciente;
        private DateTimePicker dtpFechaNacimiento;
        private ComboBox cbxSexo;
        private TextBox tbxEmail;
        private TextBox tbxTelefono;
        private TextBox tbxDireccion;
        private TextBox tbxCedula;
        private TextBox tbxApellidos;
        private TextBox tbxNombre;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}