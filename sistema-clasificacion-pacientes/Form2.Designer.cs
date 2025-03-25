namespace sistema_clasificacion_pacientes
{
    partial class Form2
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
            textUsername = new TextBox();
            textPassword = new TextBox();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();

            // textUsername
            textUsername.Font = new Font("Segoe UI", 10F);
            textUsername.Location = new Point(190, 100);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(220, 25);
            textUsername.TabIndex = 0;

            // textPassword
            textPassword.Font = new Font("Segoe UI", 10F);
            textPassword.Location = new Point(190, 150);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(220, 25);
            textPassword.TabIndex = 1;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textPassword_TextChanged;

            // label1 (Título)
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(160, 30);
            label1.Name = "label1";
            label1.Size = new Size(180, 30);
            label1.TabIndex = 2;
            label1.Text = "INICIAR SESIÓN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;

            // button1 (Confirmar)
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(190, 200);
            button1.Name = "button1";
            button1.Size = new Size(220, 35);
            button1.TabIndex = 3;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;

            // label2 (Usuario)
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(120, 103);
            label2.Name = "label2";
            label2.Size = new Size(58, 19);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;

            // label3 (Contraseña)
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(100, 153);
            label3.Name = "label3";
            label3.Size = new Size(78, 19);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            label3.TextAlign = ContentAlignment.TopCenter;

            // button2 (Salir)
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(20, 260);
            button2.Name = "button2";
            button2.Size = new Size(80, 30);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSalir_Click;

            // Form2
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(500, 320);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Font = new Font("Segoe UI", 9F);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += Form2_Load;
            checkMostrar = new CheckBox();
            checkMostrar.Font = new Font("Segoe UI", 9F);
            checkMostrar.Location = new Point(190, 180);
            checkMostrar.Size = new Size(220, 20);
            checkMostrar.Text = "Mostrar contraseña";
            checkMostrar.CheckedChanged += checkMostrar_CheckedChanged;
            Controls.Add(checkMostrar);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textUsername;
        private TextBox textPassword;
        private Label label1;
        private Button button1;
        private Label label2;
        private Label label3;
        private Button button2;
        private CheckBox checkMostrar;
    }
}