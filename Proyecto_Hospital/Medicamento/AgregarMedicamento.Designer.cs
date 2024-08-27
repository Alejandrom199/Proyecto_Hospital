namespace CapaPresentacion.Medicamento
{
    partial class AgregarMedicamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AgregarMedicamento));
            dtpFechaExpiracion = new DateTimePicker();
            label13 = new Label();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            btnBorrarCampos = new Button();
            btnAgregarMedicamento = new Button();
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
            btnProveedor = new Button();
            nudPrecio = new NumericUpDown();
            rtbIndicaciones = new RichTextBox();
            cbxProveedor = new ComboBox();
            btnPresentacion = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // dtpFechaExpiracion
            // 
            dtpFechaExpiracion.Location = new Point(247, 220);
            dtpFechaExpiracion.Name = "dtpFechaExpiracion";
            dtpFechaExpiracion.Size = new Size(342, 31);
            dtpFechaExpiracion.TabIndex = 115;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(70, 180);
            label13.Name = "label13";
            label13.Size = new Size(102, 25);
            label13.TabIndex = 114;
            label13.Text = "Dosis (mg):";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(70, 260);
            label9.Name = "label9";
            label9.Size = new Size(50, 25);
            label9.TabIndex = 105;
            label9.Text = "Lote:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(663, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(353, 596);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 104;
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
            btnBorrarCampos.TabIndex = 103;
            btnBorrarCampos.Text = "Borrar Campos";
            btnBorrarCampos.UseVisualStyleBackColor = false;
            btnBorrarCampos.Click += btnBorrarCampos_Click;
            // 
            // btnAgregarMedicamento
            // 
            btnAgregarMedicamento.BackColor = SystemColors.Highlight;
            btnAgregarMedicamento.FlatStyle = FlatStyle.Flat;
            btnAgregarMedicamento.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAgregarMedicamento.ForeColor = SystemColors.ControlLightLight;
            btnAgregarMedicamento.Location = new Point(105, 550);
            btnAgregarMedicamento.Name = "btnAgregarMedicamento";
            btnAgregarMedicamento.Size = new Size(220, 40);
            btnAgregarMedicamento.TabIndex = 102;
            btnAgregarMedicamento.Text = "Agregar Medicamento";
            btnAgregarMedicamento.UseVisualStyleBackColor = false;
            btnAgregarMedicamento.Click += btnAgregarMedicamento_Click;
            // 
            // cbxPresentacion
            // 
            cbxPresentacion.FormattingEnabled = true;
            cbxPresentacion.Location = new Point(247, 140);
            cbxPresentacion.Name = "cbxPresentacion";
            cbxPresentacion.RightToLeft = RightToLeft.No;
            cbxPresentacion.Size = new Size(310, 33);
            cbxPresentacion.TabIndex = 101;
            // 
            // tbxLote
            // 
            tbxLote.Location = new Point(312, 260);
            tbxLote.Name = "tbxLote";
            tbxLote.Size = new Size(277, 31);
            tbxLote.TabIndex = 99;
            // 
            // tbxDosis
            // 
            tbxDosis.Location = new Point(312, 180);
            tbxDosis.Name = "tbxDosis";
            tbxDosis.Size = new Size(277, 31);
            tbxDosis.TabIndex = 98;
            // 
            // tbxNombreGenerico
            // 
            tbxNombreGenerico.Location = new Point(312, 100);
            tbxNombreGenerico.Name = "tbxNombreGenerico";
            tbxNombreGenerico.Size = new Size(277, 31);
            tbxNombreGenerico.TabIndex = 97;
            // 
            // tbxNombreComercial
            // 
            tbxNombreComercial.ForeColor = SystemColors.WindowText;
            tbxNombreComercial.Location = new Point(312, 60);
            tbxNombreComercial.Name = "tbxNombreComercial";
            tbxNombreComercial.Size = new Size(277, 31);
            tbxNombreComercial.TabIndex = 96;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(168, 10);
            label12.Name = "label12";
            label12.Size = new Size(327, 32);
            label12.TabIndex = 95;
            label12.Text = "AGREGAR MEDICAMENTOS";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(70, 380);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 94;
            label8.Text = "Indicaciones:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(70, 340);
            label7.Name = "label7";
            label7.Size = new Size(98, 25);
            label7.TabIndex = 93;
            label7.Text = "Proveedor:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 300);
            label5.Name = "label5";
            label5.Size = new Size(64, 25);
            label5.TabIndex = 91;
            label5.Text = "Precio:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 220);
            label4.Name = "label4";
            label4.Size = new Size(171, 25);
            label4.TabIndex = 90;
            label4.Text = "Fecha de expiración:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 140);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 89;
            label3.Text = "Presentación:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 100);
            label2.Name = "label2";
            label2.Size = new Size(155, 25);
            label2.TabIndex = 88;
            label2.Text = "Nombre generico:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 60);
            label1.Name = "label1";
            label1.Size = new Size(167, 25);
            label1.TabIndex = 87;
            label1.Text = "Nombre comercial: ";
            // 
            // btnProveedor
            // 
            btnProveedor.BackColor = SystemColors.Highlight;
            btnProveedor.Cursor = Cursors.Hand;
            btnProveedor.FlatStyle = FlatStyle.Flat;
            btnProveedor.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnProveedor.ForeColor = SystemColors.ControlLightLight;
            btnProveedor.Location = new Point(555, 340);
            btnProveedor.Name = "btnProveedor";
            btnProveedor.Size = new Size(34, 34);
            btnProveedor.TabIndex = 110;
            btnProveedor.Text = "+";
            btnProveedor.TextAlign = ContentAlignment.TopCenter;
            btnProveedor.UseVisualStyleBackColor = false;
            btnProveedor.Click += btnProveedor_Click;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            nudPrecio.Location = new Point(312, 300);
            nudPrecio.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(278, 31);
            nudPrecio.TabIndex = 117;
            // 
            // rtbIndicaciones
            // 
            rtbIndicaciones.Location = new Point(247, 380);
            rtbIndicaciones.Name = "rtbIndicaciones";
            rtbIndicaciones.Size = new Size(342, 116);
            rtbIndicaciones.TabIndex = 118;
            rtbIndicaciones.Text = "";
            // 
            // cbxProveedor
            // 
            cbxProveedor.FormattingEnabled = true;
            cbxProveedor.Location = new Point(247, 340);
            cbxProveedor.Name = "cbxProveedor";
            cbxProveedor.RightToLeft = RightToLeft.No;
            cbxProveedor.Size = new Size(310, 33);
            cbxProveedor.TabIndex = 119;
            // 
            // btnPresentacion
            // 
            btnPresentacion.BackColor = SystemColors.Highlight;
            btnPresentacion.Cursor = Cursors.Hand;
            btnPresentacion.FlatStyle = FlatStyle.Flat;
            btnPresentacion.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            btnPresentacion.ForeColor = SystemColors.ControlLightLight;
            btnPresentacion.Location = new Point(556, 140);
            btnPresentacion.Name = "btnPresentacion";
            btnPresentacion.Size = new Size(34, 34);
            btnPresentacion.TabIndex = 120;
            btnPresentacion.Text = "+";
            btnPresentacion.TextAlign = ContentAlignment.TopCenter;
            btnPresentacion.UseVisualStyleBackColor = false;
            btnPresentacion.Click += btnPresentacion_Click;
            // 
            // AgregarMedicamento
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(btnPresentacion);
            Controls.Add(cbxProveedor);
            Controls.Add(rtbIndicaciones);
            Controls.Add(nudPrecio);
            Controls.Add(dtpFechaExpiracion);
            Controls.Add(label13);
            Controls.Add(btnProveedor);
            Controls.Add(label9);
            Controls.Add(pictureBox1);
            Controls.Add(btnBorrarCampos);
            Controls.Add(btnAgregarMedicamento);
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
            Name = "AgregarMedicamento";
            Text = "AgregarMedicamento";
            Load += AgregarMedicamento_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpFechaExpiracion;
        private Label label13;
        private Label label9;
        private PictureBox pictureBox1;
        private Button btnBorrarCampos;
        private Button btnAgregarMedicamento;
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
        private Button btnProveedor;
        private NumericUpDown nudPrecio;
        private RichTextBox rtbIndicaciones;
        private ComboBox cbxProveedor;
        private Button btnPresentacion;
    }
}