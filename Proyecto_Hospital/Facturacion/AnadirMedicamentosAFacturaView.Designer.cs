namespace CapaPresentacion.Facturacion
{
    partial class AnadirMedicamentosAFacturaView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnadirMedicamentosAFacturaView));
            label3 = new Label();
            btnCerrar = new Button();
            cbxMedicamentos = new ComboBox();
            label1 = new Label();
            btnAgregarAFactura = new Button();
            dgvMedimentosFactura2 = new DataGridView();
            label2 = new Label();
            tbxCantidad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvMedimentosFactura2).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Highlight;
            label3.Location = new Point(262, 9);
            label3.Name = "label3";
            label3.Size = new Size(272, 25);
            label3.TabIndex = 23;
            label3.Text = "MEDICAMENTOS EN FACTURA";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Red;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCerrar.ForeColor = SystemColors.ControlLightLight;
            btnCerrar.Location = new Point(743, 16);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.TabIndex = 24;
            btnCerrar.Text = "X";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cbxMedicamentos
            // 
            cbxMedicamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxMedicamentos.FormattingEnabled = true;
            cbxMedicamentos.Location = new Point(157, 62);
            cbxMedicamentos.Name = "cbxMedicamentos";
            cbxMedicamentos.Size = new Size(353, 33);
            cbxMedicamentos.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 60);
            label1.Name = "label1";
            label1.Size = new Size(125, 25);
            label1.TabIndex = 26;
            label1.Text = "Medicamento:";
            // 
            // btnAgregarAFactura
            // 
            btnAgregarAFactura.BackColor = SystemColors.Highlight;
            btnAgregarAFactura.FlatStyle = FlatStyle.Flat;
            btnAgregarAFactura.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarAFactura.ForeColor = SystemColors.ControlLightLight;
            btnAgregarAFactura.Location = new Point(516, 62);
            btnAgregarAFactura.Name = "btnAgregarAFactura";
            btnAgregarAFactura.Size = new Size(204, 34);
            btnAgregarAFactura.TabIndex = 27;
            btnAgregarAFactura.Text = "Agregar a la factura";
            btnAgregarAFactura.UseVisualStyleBackColor = false;
            btnAgregarAFactura.Click += btnAgregarAFactura_Click;
            // 
            // dgvMedimentosFactura2
            // 
            dgvMedimentosFactura2.BackgroundColor = SystemColors.InactiveCaption;
            dgvMedimentosFactura2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedimentosFactura2.Location = new Point(26, 146);
            dgvMedimentosFactura2.Name = "dgvMedimentosFactura2";
            dgvMedimentosFactura2.RowHeadersWidth = 62;
            dgvMedimentosFactura2.Size = new Size(757, 292);
            dgvMedimentosFactura2.TabIndex = 28;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 100);
            label2.Name = "label2";
            label2.Size = new Size(87, 25);
            label2.TabIndex = 29;
            label2.Text = "Cantidad:";
            // 
            // tbxCantidad
            // 
            tbxCantidad.Location = new Point(157, 101);
            tbxCantidad.Name = "tbxCantidad";
            tbxCantidad.Size = new Size(171, 31);
            tbxCantidad.TabIndex = 30;
            // 
            // AnadirMedicamentosAFacturaView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(tbxCantidad);
            Controls.Add(label2);
            Controls.Add(dgvMedimentosFactura2);
            Controls.Add(btnAgregarAFactura);
            Controls.Add(label1);
            Controls.Add(cbxMedicamentos);
            Controls.Add(btnCerrar);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnadirMedicamentosAFacturaView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnadirMedicamentosAFacturaView";
            Load += AnadirMedicamentosAFacturaView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedimentosFactura2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Button btnCerrar;
        private ComboBox cbxMedicamentos;
        private Label label1;
        private Button btnAgregarAFactura;
        private DataGridView dgvMedimentosFactura2;
        private Label label2;
        private TextBox tbxCantidad;
    }
}