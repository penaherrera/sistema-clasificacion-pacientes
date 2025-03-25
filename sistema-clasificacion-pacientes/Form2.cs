using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_clasificacion_pacientes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void checkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            textPassword.UseSystemPasswordChar = !checkMostrar.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textUsername.Text;
            string password = textPassword.Text;

            if (usuario == "admin" && password == "1234")
            {
                MessageBox.Show("Inicio de sesión exitoso", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el formulario principal
                Form1 mainForm = new Form1();
                mainForm.Show();

                // Ocultar el login en lugar de cerrarlo
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
