namespace CapaPresentacion
{
    partial class ListarMedicamentoView
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
            dgvMedicamentos = new DataGridView();
            tbxValor = new TextBox();
            btnBuscarMedico = new Button();
            lblValor = new Label();
            cbxFiltro = new ComboBox();
            label2 = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).BeginInit();
            SuspendLayout();
            // 
            // dgvMedicamentos
            // 
            dgvMedicamentos.BackgroundColor = SystemColors.InactiveCaption;
            dgvMedicamentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMedicamentos.Location = new Point(12, 171);
            dgvMedicamentos.Name = "dgvMedicamentos";
            dgvMedicamentos.RowHeadersWidth = 62;
            dgvMedicamentos.Size = new Size(990, 414);
            dgvMedicamentos.TabIndex = 0;
            // 
            // tbxValor
            // 
            tbxValor.Location = new Point(449, 125);
            tbxValor.Name = "tbxValor";
            tbxValor.Size = new Size(214, 31);
            tbxValor.TabIndex = 30;
            // 
            // btnBuscarMedico
            // 
            btnBuscarMedico.BackColor = SystemColors.Highlight;
            btnBuscarMedico.Cursor = Cursors.Hand;
            btnBuscarMedico.FlatStyle = FlatStyle.Flat;
            btnBuscarMedico.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscarMedico.ForeColor = SystemColors.ControlLightLight;
            btnBuscarMedico.Location = new Point(679, 125);
            btnBuscarMedico.Name = "btnBuscarMedico";
            btnBuscarMedico.Size = new Size(214, 34);
            btnBuscarMedico.TabIndex = 29;
            btnBuscarMedico.Text = "Buscar Medicamento";
            btnBuscarMedico.UseVisualStyleBackColor = false;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(366, 125);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(56, 25);
            lblValor.TabIndex = 28;
            lblValor.Text = "Valor:";
            lblValor.TextAlign = ContentAlignment.MiddleRight;
            // 
            // cbxFiltro
            // 
            cbxFiltro.FormattingEnabled = true;
            cbxFiltro.Items.AddRange(new object[] { "Id", "Nombre", "Apellido", "Cedula" });
            cbxFiltro.Location = new Point(110, 125);
            cbxFiltro.Name = "cbxFiltro";
            cbxFiltro.Size = new Size(227, 33);
            cbxFiltro.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 125);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 26;
            label2.Text = "Filtrar por:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = SystemColors.HotTrack;
            label12.Location = new Point(331, 10);
            label12.Name = "label12";
            label12.Size = new Size(350, 32);
            label12.TabIndex = 25;
            label12.Text = "LISTADO DE MEDICAMENTOS";
            // 
            // ListarMedicamentoView
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1014, 596);
            Controls.Add(tbxValor);
            Controls.Add(btnBuscarMedico);
            Controls.Add(lblValor);
            Controls.Add(cbxFiltro);
            Controls.Add(label2);
            Controls.Add(label12);
            Controls.Add(dgvMedicamentos);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ListarMedicamentoView";
            Text = "MedicamentoView";
            Load += MedicamentoView_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMedicamentos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMedicamentos;
        private TextBox tbxValor;
        private Button btnBuscarMedico;
        private Label lblValor;
        private ComboBox cbxFiltro;
        private Label label2;
        private Label label12;
    }
}