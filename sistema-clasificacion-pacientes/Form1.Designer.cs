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
            txtNombre.Location = new Point(147, 77);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(180, 25);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 1;
            label1.Text = "Registrar Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(59, 19);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(29, 130);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 3;
            label3.Text = "Género";
            // 
            // cmbGenero
            // 
            cmbGenero.Font = new Font("Segoe UI", 10F);
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGenero.Location = new Point(147, 127);
            cmbGenero.Margin = new Padding(3, 2, 3, 2);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(180, 25);
            cmbGenero.TabIndex = 4;
            // 
            // cmbTipoSanguineo
            // 
            cmbTipoSanguineo.Font = new Font("Segoe UI", 10F);
            cmbTipoSanguineo.FormattingEnabled = true;
            cmbTipoSanguineo.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cmbTipoSanguineo.Location = new Point(147, 177);
            cmbTipoSanguineo.Margin = new Padding(3, 2, 3, 2);
            cmbTipoSanguineo.Name = "cmbTipoSanguineo";
            cmbTipoSanguineo.Size = new Size(180, 25);
            cmbTipoSanguineo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(29, 180);
            label4.Name = "label4";
            label4.Size = new Size(102, 19);
            label4.TabIndex = 5;
            label4.Text = "Tipo sanguíneo";
            // 
            // cmbPresionArterial
            // 
            cmbPresionArterial.Font = new Font("Segoe UI", 10F);
            cmbPresionArterial.FormattingEnabled = true;
            cmbPresionArterial.Items.AddRange(new object[] { "Baja", "Normal", "Alta" });
            cmbPresionArterial.Location = new Point(147, 227);
            cmbPresionArterial.Margin = new Padding(3, 2, 3, 2);
            cmbPresionArterial.Name = "cmbPresionArterial";
            cmbPresionArterial.Size = new Size(180, 25);
            cmbPresionArterial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(29, 230);
            label5.Name = "label5";
            label5.Size = new Size(100, 19);
            label5.TabIndex = 7;
            label5.Text = "Presión arterial";
            // 
            // btnRegistrar
            // 
            btnRegistrar.BackColor = Color.MediumSeaGreen;
            btnRegistrar.FlatStyle = FlatStyle.Flat;
            btnRegistrar.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnRegistrar.ForeColor = Color.White;
            btnRegistrar.Location = new Point(116, 280);
            btnRegistrar.Margin = new Padding(3, 2, 3, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(129, 35);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = false;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(245, 250, 255);
            dgvPacientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPacientes.BackgroundColor = Color.White;
            dgvPacientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(30, 136, 229);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvPacientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPacientes.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(184, 215, 252);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPacientes.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPacientes.EnableHeadersVisualStyles = false;
            dgvPacientes.GridColor = Color.LightGray;
            dgvPacientes.Location = new Point(350, 20);
            dgvPacientes.Margin = new Padding(3, 2, 3, 2);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.RowHeadersVisible = false;
            dgvPacientes.Size = new Size(1138, 380);
            dgvPacientes.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnSalir.ForeColor = Color.White;
            btnSalir.Location = new Point(29, 330);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(100, 30);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1500, 450);
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
            Margin = new Padding(3, 2, 3, 2);
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
