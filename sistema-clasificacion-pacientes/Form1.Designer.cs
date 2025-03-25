namespace sistema_clasificacion_pacientes
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtNombre = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            cmbGenero = new ComboBox();
            cmbTipoSanguineo = new ComboBox();
            label4 = new Label();
            cmbPresionArterial = new ComboBox();
            label5 = new Label();
            btnRegistrar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvPacientes = new DataGridView();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 10F);
            txtNombre.Location = new Point(168, 103);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(205, 30);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(33, 27);
            label1.Name = "label1";
            label1.Size = new Size(220, 32);
            label1.TabIndex = 1;
            label1.Text = "Registrar Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(33, 107);
            label2.Name = "label2";
            label2.Size = new Size(73, 23);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(33, 173);
            label3.Name = "label3";
            label3.Size = new Size(66, 23);
            label3.TabIndex = 3;
            label3.Text = "Género";
            // 
            // cmbGenero
            // 
            cmbGenero.Font = new Font("Segoe UI", 10F);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGenero.Location = new Point(168, 169);
            cmbGenero.Margin = new Padding(3, 4, 3, 4);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(205, 31);
            cmbGenero.TabIndex = 4;
            // 
            // cmbTipoSanguineo
            // 
            cmbTipoSanguineo.Font = new Font("Segoe UI", 10F);
            cmbTipoSanguineo.FormattingEnabled = true;
            cmbTipoSanguineo.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cmbTipoSanguineo.Location = new Point(168, 236);
            cmbTipoSanguineo.Margin = new Padding(3, 4, 3, 4);
            cmbTipoSanguineo.Name = "cmbTipoSanguineo";
            cmbTipoSanguineo.Size = new Size(205, 31);
            cmbTipoSanguineo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(33, 240);
            label4.Name = "label4";
            label4.Size = new Size(127, 23);
            label4.TabIndex = 5;
            label4.Text = "Tipo sanguíneo";
            // 
            // cmbPresionArterial
            // 
            cmbPresionArterial.Font = new Font("Segoe UI", 10F);
            cmbPresionArterial.FormattingEnabled = true;
            cmbPresionArterial.Items.AddRange(new object[] { "Baja", "Normal", "Alta" });
            cmbPresionArterial.Location = new Point(168, 303);
            cmbPresionArterial.Margin = new Padding(3, 4, 3, 4);
            cmbPresionArterial.Name = "cmbPresionArterial";
            cmbPresionArterial.Size = new Size(205, 31);
            cmbPresionArterial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(33, 307);
            label5.Name = "label5";
            label5.Size = new Size(124, 23);
            label5.TabIndex = 7;
            label5.Text = "Presión arterial";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.MediumSeaGreen;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(132, 373);
            btnRegistrar.Margin = new Padding(3, 4, 3, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(147, 47);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 248, 255);
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(32, 136, 203);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(184, 215, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.GridColor = Color.LightGray;
            dgvPacientes.Location = new Point(400, 27);
            dgvPacientes.Margin = new Padding(3, 4, 3, 4);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.RowHeadersWidth = 51;
            dgvPacientes.Size = new Size(1086, 507);
            dgvPacientes.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(33, 440);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(114, 40);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1543, 600);
            Controls.Add(btnSalir);
            Controls.Add(dgvPacientes);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbPresionArterial);
            Controls.Add(label5);
            Controls.Add(cmbTipoSanguineo);
            Controls.Add(label4);
            Controls.Add(cmbGenero);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Registro de Pacientes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Cierra la aplicación al cerrar el formulario principal
            Application.Exit();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox cmbGenero;
        private ComboBox cmbTipoSanguineo;
        private Label label4;
        private ComboBox cmbPresionArterial;
        private Label label5;
        private Button btnRegistrar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvPacientes;
        private Button btnSalir;
    }
}
