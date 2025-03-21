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
            txtNombre.Location = new Point(147, 77);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(121, 23);
            txtNombre.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 39);
            label1.Name = "label1";
            label1.Size = new Size(101, 15);
            label1.TabIndex = 1;
            label1.Text = "Registrar Paciente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 85);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 147);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Genero";
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Masculino", "Femenino" });
            cmbGenero.Location = new Point(147, 139);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(121, 23);
            cmbGenero.TabIndex = 4;
            // 
            // cmbTipoSanguineo
            // 
            cmbTipoSanguineo.FormattingEnabled = true;
            cmbTipoSanguineo.Items.AddRange(new object[] { "A", "B", "AB", "O" });
            cmbTipoSanguineo.Location = new Point(147, 202);
            cmbTipoSanguineo.Name = "cmbTipoSanguineo";
            cmbTipoSanguineo.Size = new Size(121, 23);
            cmbTipoSanguineo.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 210);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 5;
            label4.Text = "Tipo Sanguineo";
            // 
            // cmbPresionArterial
            // 
            cmbPresionArterial.FormattingEnabled = true;
            cmbPresionArterial.Items.AddRange(new object[] { "Baja", "Normal", "Alta" });
            cmbPresionArterial.Location = new Point(147, 269);
            cmbPresionArterial.Name = "cmbPresionArterial";
            cmbPresionArterial.Size = new Size(121, 23);
            cmbPresionArterial.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 277);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 7;
            label5.Text = "Presion Arterial";
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(29, 322);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(229, 23);
            btnRegistrar.TabIndex = 9;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // dgvPacientes
            // 
            dgvPacientes.AllowUserToAddRows = false;
            dgvPacientes.AllowUserToDeleteRows = false;
            dgvPacientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPacientes.Location = new Point(289, 39);
            dgvPacientes.Name = "dgvPacientes";
            dgvPacientes.ReadOnly = true;
            dgvPacientes.Size = new Size(1049, 380);
            dgvPacientes.TabIndex = 10;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(29, 415);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(75, 23);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 450);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPacientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
