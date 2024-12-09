namespace CapaPresentacion.Facturacion
{
    partial class AgregarFacturacionView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarFacturacionView));
            rtbObservaciones = new RichTextBox();
            pictureBox1 = new PictureBox();
            btnBorrarCampos = new Button();
            btnAgregarFacturacion = new Button();
            label12 = new Label();
            label8 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            cbxMedico = new ComboBox();
            cbxPaciente = new ComboBox();
            cbxMetodoPago = new ComboBox();
            btnGenerarFactura = new Button();
            label6 = new Label();
            lblNoFactura = new Label();
            label3 = new Label();
            label4 = new Label();
            tbxMontoTotal = new TextBox();
            btnAnadirMedicamentosFactura = new Button();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnGetMonto = new Button();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // rtbObservaciones
            // 
            rtbObservaciones.Location = new Point(251, 273);
            rtbObservaciones.Name = "rtbObservaciones";
            rtbObservaciones.Size = new Size(342, 80);
            rtbObservaciones.TabIndex = 142;
            rtbObservaciones.Text = "";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 136;
            pictureBox1.TabStop = false;
            // 
            // btnBorrarCampos
            // 
            btnBorrarCampos.BackColor = SystemColors.Highlight;
            btnBorrarCampos.FlatStyle = FlatStyle.Flat;
            btnBorrarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarCampos.ForeColor = SystemColors.ControlLightLight;
            btnBorrarCampos.Location = new Point(344, 550);
            btnBorrarCampos.Name = "btnBorrarCampos";
            btnBorrarCampos.Size = new Size(182, 40);
            btnBorrarCampos.TabIndex = 135;
            btnBorrarCampos.Text = "Borrar Campos";
            btnBorrarCampos.UseVisualStyleBackColor = false;
            btnBorrarCampos.Click += btnBorrarCampos_Click;
            // 
            // btnAgregarFacturacion
            // 
            btnAgregarFacturacion.BackColor = SystemColors.Highlight;
            btnAgregarFacturacion.FlatStyle = FlatStyle.Flat;
            btnAgregarFacturacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarFacturacion.ForeColor = SystemColors.ControlLightLight;
            btnAgregarFacturacion.Location = new Point(105, 550);
            btnAgregarFacturacion.Name = "btnAgregarFacturacion";
            btnAgregarFacturacion.Size = new Size(220, 40);
            btnAgregarFacturacion.TabIndex = 134;
            btnAgregarFacturacion.Text = "Agregar Facturación";
            btnAgregarFacturacion.UseVisualStyleBackColor = false;
            btnAgregarFacturacion.Click += btnAgregarFacturacion_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(168, 10);
            label12.Name = "label12";
            label12.Size = new Size(327, 32);
            label12.TabIndex = 128;
            label12.Text = "AGREGAR FACTURACIÓNES";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(74, 273);
            label8.Name = "label8";
            label8.Size = new Size(132, 25);
            label8.TabIndex = 127;
            label8.Text = "Observaciones:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(74, 233);
            label5.Name = "label5";
            label5.Size = new Size(150, 25);
            label5.TabIndex = 125;
            label5.Text = "Método de Pago:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 195);
            label2.Name = "label2";
            label2.Size = new Size(75, 25);
            label2.TabIndex = 122;
            label2.Text = "Médico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(74, 155);
            label1.Name = "label1";
            label1.Size = new Size(85, 25);
            label1.TabIndex = 121;
            label1.Text = "Paciente: ";
            // 
            // cbxMedico
            // 
            cbxMedico.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMedico.FormattingEnabled = true;
            cbxMedico.Location = new Point(316, 195);
            cbxMedico.Name = "cbxMedico";
            cbxMedico.RightToLeft = RightToLeft.No;
            cbxMedico.Size = new Size(277, 33);
            cbxMedico.TabIndex = 143;
            // 
            // cbxPaciente
            // 
            cbxPaciente.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxPaciente.FormattingEnabled = true;
            cbxPaciente.Location = new Point(316, 155);
            cbxPaciente.Name = "cbxPaciente";
            cbxPaciente.RightToLeft = RightToLeft.No;
            cbxPaciente.Size = new Size(277, 33);
            cbxPaciente.TabIndex = 144;
            // 
            // cbxMetodoPago
            // 
            cbxMetodoPago.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMetodoPago.FormattingEnabled = true;
            cbxMetodoPago.Items.AddRange(new object[] { "EFECTIVO" });
            cbxMetodoPago.Location = new Point(316, 234);
            cbxMetodoPago.Name = "cbxMetodoPago";
            cbxMetodoPago.RightToLeft = RightToLeft.No;
            cbxMetodoPago.Size = new Size(277, 33);
            cbxMetodoPago.TabIndex = 148;
            // 
            // btnGenerarFactura
            // 
            btnGenerarFactura.BackColor = SystemColors.Highlight;
            btnGenerarFactura.FlatStyle = FlatStyle.Flat;
            btnGenerarFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerarFactura.ForeColor = SystemColors.ControlLightLight;
            btnGenerarFactura.Location = new Point(251, 68);
            btnGenerarFactura.Name = "btnGenerarFactura";
            btnGenerarFactura.Size = new Size(168, 40);
            btnGenerarFactura.TabIndex = 151;
            btnGenerarFactura.Text = "Generar Factura";
            btnGenerarFactura.UseVisualStyleBackColor = false;
            btnGenerarFactura.Click += btnGenerarFactura_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(1, 18);
            label6.Name = "label6";
            label6.Size = new Size(113, 25);
            label6.TabIndex = 152;
            label6.Text = "No factura:";
            // 
            // lblNoFactura
            // 
            lblNoFactura.AutoSize = true;
            lblNoFactura.Location = new Point(111, 17);
            lblNoFactura.Name = "lblNoFactura";
            lblNoFactura.Size = new Size(0, 25);
            lblNoFactura.TabIndex = 153;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 44);
            label3.Name = "label3";
            label3.Size = new Size(133, 25);
            label3.TabIndex = 123;
            label3.Text = "Medicamentos:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 83);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 124;
            label4.Text = "Monto Total:";
            // 
            // tbxMontoTotal
            // 
            tbxMontoTotal.Location = new Point(232, 85);
            tbxMontoTotal.Name = "tbxMontoTotal";
            tbxMontoTotal.ReadOnly = true;
            tbxMontoTotal.Size = new Size(139, 31);
            tbxMontoTotal.TabIndex = 145;
            tbxMontoTotal.Text = "0";
            // 
            // btnAnadirMedicamentosFactura
            // 
            btnAnadirMedicamentosFactura.BackColor = SystemColors.Highlight;
            btnAnadirMedicamentosFactura.FlatStyle = FlatStyle.Flat;
            btnAnadirMedicamentosFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAnadirMedicamentosFactura.ForeColor = SystemColors.ControlLightLight;
            btnAnadirMedicamentosFactura.Location = new Point(232, 44);
            btnAnadirMedicamentosFactura.Name = "btnAnadirMedicamentosFactura";
            btnAnadirMedicamentosFactura.Size = new Size(309, 33);
            btnAnadirMedicamentosFactura.TabIndex = 149;
            btnAnadirMedicamentosFactura.Text = "Añadir Medicamentos";
            btnAnadirMedicamentosFactura.UseVisualStyleBackColor = false;
            btnAnadirMedicamentosFactura.Click += btnAnadirMedicamentosFactura_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnGetMonto);
            groupBox1.Controls.Add(btnAnadirMedicamentosFactura);
            groupBox1.Controls.Add(tbxMontoTotal);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(48, 366);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(562, 178);
            groupBox1.TabIndex = 150;
            groupBox1.TabStop = false;
            groupBox1.Text = "Añadir Medicamentos a la Factura";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(40, 137);
            label7.Name = "label7";
            label7.Size = new Size(485, 25);
            label7.TabIndex = 151;
            label7.Text = "Para generar la facturación debe dar click a 'Generar Monto'.";
            // 
            // btnGetMonto
            // 
            btnGetMonto.BackColor = Color.DeepSkyBlue;
            btnGetMonto.FlatStyle = FlatStyle.Flat;
            btnGetMonto.Font = new Font("Segoe UI Black", 9F);
            btnGetMonto.ForeColor = SystemColors.ControlLightLight;
            btnGetMonto.Location = new Point(378, 83);
            btnGetMonto.Name = "btnGetMonto";
            btnGetMonto.Size = new Size(163, 34);
            btnGetMonto.TabIndex = 150;
            btnGetMonto.Text = "Generar Monto";
            btnGetMonto.UseVisualStyleBackColor = false;
            btnGetMonto.Click += btnGetMonto_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblNoFactura);
            groupBox2.Controls.Add(label6);
            groupBox2.Location = new Point(425, 58);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(168, 49);
            groupBox2.TabIndex = 154;
            groupBox2.TabStop = false;
            // 
            // AgregarFacturacionView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(groupBox2);
            Controls.Add(btnGenerarFactura);
            Controls.Add(groupBox1);
            Controls.Add(cbxMetodoPago);
            Controls.Add(cbxPaciente);
            Controls.Add(cbxMedico);
            Controls.Add(rtbObservaciones);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrarCampos);
            Controls.Add(btnAgregarFacturacion);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarFacturacionView";
            Text = "AgregarFacturacionView";
            Load += AgregarFacturacionView_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private RichTextBox rtbObservaciones;
        private PictureBox pictureBox1;
        private Button btnBorrarCampos;
        private Button btnAgregarFacturacion;
        private Label label12;
        private Label label8;
        private Label label5;
        private Label label2;
        private Label label1;
        private ComboBox cbxMedico;
        private ComboBox cbxPaciente;
        private ComboBox cbxMetodoPago;
        private Button btnGenerarFactura;
        private Label label6;
        private Label lblNoFactura;
        private Label label3;
        private Label label4;
        private TextBox tbxMontoTotal;
        private Button btnAnadirMedicamentosFactura;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button btnGetMonto;
        private Label label7;
    }
}