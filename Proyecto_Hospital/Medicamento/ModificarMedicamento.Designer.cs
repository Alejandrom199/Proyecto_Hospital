namespace CapaPresentacion.Medicamento
{
    partial class ModificarMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarMedicamento));
            cbxProveedor = new ComboBox();
            rtbIndicaciones = new RichTextBox();
            nudPrecio = new NumericUpDown();
            dtpFechaExpiracion = new DateTimePicker();
            label13 = new Label();
            label9 = new Label();
            cbxPresentacion = new ComboBox();
            tbxLote = new TextBox();
            tbxDosis = new TextBox();
            tbxNombreGenerico = new TextBox();
            tbxNombreComercial = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnBuscar = new Button();
            tbxId = new TextBox();
            label11 = new Label();
            pictureBox1 = new PictureBox();
            btnBorrarCampos = new Button();
            btnModificarMedicamento = new Button();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // cbxProveedor
            // 
            cbxProveedor.FormattingEnabled = true;
            cbxProveedor.Location = new Point(247, 380);
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.RightToLeft = RightToLeft.No;
            cbxProveedor.Size = new Size(343, 33);
            cbxProveedor.TabIndex = 140;
            // 
            // rtbIndicaciones
            // 
            rtbIndicaciones.Location = new Point(247, 420);
            rtbIndicaciones.Name = "rtbIndicaciones";
            rtbIndicaciones.Size = new Size(342, 116);
            rtbIndicaciones.TabIndex = 139;
            rtbIndicaciones.Text = "";
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Location = new Point(312, 340);
            nudPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(278, 31);
            nudPrecio.TabIndex = 138;
            // 
            // dtpFechaExpiracion
            // 
            dtpFechaExpiracion.Location = new Point(247, 260);
            dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            dtpFechaExpiracion.Size = new Size(342, 31);
            dtpFechaExpiracion.TabIndex = 137;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 220);
            label13.Name = "label13";
            label13.Size = new Size(102, 25);
            label13.TabIndex = 136;
            label13.Text = "Dosis (mg):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 300);
            label9.Name = "label9";
            label9.Size = new Size(50, 25);
            label9.TabIndex = 134;
            label9.Text = "Lote:";
            // 
            // cbxPresentacion
            // 
            cbxPresentacion.FormattingEnabled = true;
            cbxPresentacion.Location = new Point(247, 180);
            cbxPresentacion.Name = "cbxPresentacion";
            cbxPresentacion.RightToLeft = RightToLeft.No;
            cbxPresentacion.Size = new Size(343, 33);
            cbxPresentacion.TabIndex = 133;
            // 
            // tbxLote
            // 
            tbxLote.Location = new Point(312, 300);
            tbxLote.Name = "tbxLote";
            tbxLote.Size = new Size(277, 31);
            tbxLote.TabIndex = 132;
            // 
            // tbxDosis
            // 
            tbxDosis.Location = new Point(312, 220);
            tbxDosis.Name = "tbxDosis";
            tbxDosis.Size = new Size(277, 31);
            tbxDosis.TabIndex = 131;
            // 
            // tbxNombreGenerico
            // 
            tbxNombreGenerico.Location = new Point(312, 140);
            tbxNombreGenerico.Name = "tbxNombreGenerico";
            tbxNombreGenerico.Size = new Size(277, 31);
            tbxNombreGenerico.TabIndex = 130;
            // 
            // tbxNombreComercial
            // 
            tbxNombreComercial.ForeColor = SystemColors.WindowText;
            tbxNombreComercial.Location = new Point(312, 100);
            tbxNombreComercial.Name = "tbxNombreComercial";
            tbxNombreComercial.Size = new Size(277, 31);
            tbxNombreComercial.TabIndex = 129;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(168, 10);
            label12.Name = "label12";
            label12.Size = new Size(349, 32);
            label12.TabIndex = 128;
            label12.Text = "MODIFICAR MEDICAMENTOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 420);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 127;
            label8.Text = "Indicaciones:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 380);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 126;
            label7.Text = "Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 340);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 125;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 260);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 124;
            label4.Text = "Fecha de expiración:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 180);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 123;
            label3.Text = "Presentación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 140);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 122;
            label2.Text = "Nombre generico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 100);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 121;
            label1.Text = "Nombre comercial: ";
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Highlight;
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ForeColor = SystemColors.ControlLightLight;
            btnBuscar.Location = new Point(477, 60);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(112, 34);
            btnBuscar.TabIndex = 144;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tbxId
            // 
            tbxId.Location = new Point(312, 60);
            tbxId.Name = "tbxId";
            tbxId.Size = new Size(150, 31);
            tbxId.TabIndex = 143;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(70, 60);
            label11.Name = "label11";
            label11.Size = new Size(34, 25);
            label11.TabIndex = 142;
            label11.Text = "ID:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 145;
            pictureBox1.TabStop = false;
            // 
            // btnBorrarCampos
            // 
            btnBorrarCampos.BackColor = SystemColors.Highlight;
            btnBorrarCampos.FlatStyle = FlatStyle.Flat;
            btnBorrarCampos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnBorrarCampos.ForeColor = SystemColors.ControlLightLight;
            btnBorrarCampos.Location = new Point(315, 550);
            btnBorrarCampos.Name = "btnBorrarCampos";
            btnBorrarCampos.Size = new Size(270, 40);
            btnBorrarCampos.TabIndex = 147;
            btnBorrarCampos.Text = "Modificar otro Medicamento";
            btnBorrarCampos.UseVisualStyleBackColor = false;
            btnBorrarCampos.Click += btnBorrarCampos_Click;
            // 
            // btnModificarMedicamento
            // 
            btnModificarMedicamento.BackColor = SystemColors.Highlight;
            btnModificarMedicamento.FlatStyle = FlatStyle.Flat;
            btnModificarMedicamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnModificarMedicamento.ForeColor = SystemColors.ControlLightLight;
            btnModificarMedicamento.Location = new Point(80, 550);
            btnModificarMedicamento.Name = "btnModificarMedicamento";
            btnModificarMedicamento.Size = new Size(229, 40);
            btnModificarMedicamento.TabIndex = 146;
            btnModificarMedicamento.Text = "Modificar Medicamento";
            btnModificarMedicamento.UseVisualStyleBackColor = false;
            btnModificarMedicamento.Click += btnModificarMedicamento_Click;
            // 
            // ModificarMedicamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(btnBorrarCampos);
            Controls.Add(btnModificarMedicamento);
            Controls.Add(pictureBox1);
            Controls.Add(btnBuscar);
            Controls.Add(tbxId);
            Controls.Add(label11);
            Controls.Add(cbxProveedor);
            Controls.Add(rtbIndicaciones);
            Controls.Add(nudPrecio);
            Controls.Add(dtpFechaExpiracion);
            Controls.Add(label13);
            Controls.Add(label9);
            Controls.Add(cbxPresentacion);
            Controls.Add(tbxLote);
            Controls.Add(tbxDosis);
            Controls.Add(tbxNombreGenerico);
            Controls.Add(tbxNombreComercial);
            Controls.Add(label12);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModificarMedicamento";
            Text = "ModificarMedicamento";
            Load += ModificarMedicamento_Load;
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbxProveedor;
        private RichTextBox rtbIndicaciones;
        private NumericUpDown nudPrecio;
        private DateTimePicker dtpFechaExpiracion;
        private Label label13;
        private Label label9;
        private ComboBox cbxPresentacion;
        private TextBox tbxLote;
        private TextBox tbxDosis;
        private TextBox tbxNombreGenerico;
        private TextBox tbxNombreComercial;
        private Label label12;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnBuscar;
        private TextBox tbxId;
        private Label label11;
        private PictureBox pictureBox1;
        private Button btnBorrarCampos;
        private Button btnModificarMedicamento;
    }
}