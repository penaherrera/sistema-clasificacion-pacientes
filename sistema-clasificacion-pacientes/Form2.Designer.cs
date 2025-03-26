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
            checkMostrar = new CheckBox();
            SuspendLayout();
            // 
            // textUsername
            // 
            textUsername.Font = new Font("Segoe UI", 10F);
            textUsername.Location = new Point(217, 133);
            textUsername.Margin = new Padding(3, 4, 3, 4);
            textUsername.Name = "textUsername";
            textUsername.Size = new Size(251, 30);
            textUsername.TabIndex = 0;
            // 
            // textPassword
            // 
            textPassword.Font = new Font("Segoe UI", 10F);
            textPassword.Location = new Point(217, 200);
            textPassword.Margin = new Padding(3, 4, 3, 4);
            textPassword.Name = "textPassword";
            textPassword.Size = new Size(251, 30);
            textPassword.TabIndex = 1;
            textPassword.UseSystemPasswordChar = true;
            textPassword.TextChanged += textPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightBlue;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(183, 40);
            label1.Name = "label1";
            label1.Size = new Size(220, 37);
            label1.TabIndex = 2;
            label1.Text = "INICIAR SESIÓN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.ForeColor = Color.White;
            button1.Location = new Point(217, 267);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(251, 47);
            button1.TabIndex = 3;
            button1.Text = "Confirmar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(137, 137);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 4;
            label2.Text = "Usuario:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(114, 204);
            label3.Name = "label3";
            label3.Size = new Size(101, 23);
            label3.TabIndex = 5;
            label3.Text = "Contraseña:";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.ForeColor = Color.White;
            button2.Location = new Point(23, 347);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(91, 40);
            button2.TabIndex = 6;
            button2.Text = "Salir";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnSalir_Click;
            // 
            // checkMostrar
            // 
            checkMostrar.BackColor = Color.Transparent;
            checkMostrar.Font = new Font("Segoe UI", 9F);
            checkMostrar.Location = new Point(217, 240);
            checkMostrar.Margin = new Padding(3, 4, 3, 4);
            checkMostrar.Name = "checkMostrar";
            checkMostrar.Size = new Size(251, 27);
            checkMostrar.TabIndex = 7;
            checkMostrar.Text = "Mostrar contraseña";
            checkMostrar.UseVisualStyleBackColor = false;
            checkMostrar.CheckedChanged += checkMostrar_CheckedChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(571, 427);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textPassword);
            Controls.Add(textUsername);
            Controls.Add(checkMostrar);
            Font = new Font("Segoe UI", 9F);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio de Sesión";
            Load += Form2_Load;
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