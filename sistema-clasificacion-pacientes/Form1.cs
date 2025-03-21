namespace sistema_clasificacion_pacientes
{
    public partial class Form1 : Form
    {
        private List<Paciente> listaPacientes;
        private ArbolPacientes arbolPacientes;
        public Form1()
        {
            InitializeComponent();
            listaPacientes = new List<Paciente>();
            arbolPacientes = new ArbolPacientes();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvPacientes.Columns.Add("Nombre", "Nombre");
            dgvPacientes.Columns.Add("Genero", "Género");
            dgvPacientes.Columns.Add("TipoSanguineo", "Tipo Sanguíneo");
            dgvPacientes.Columns.Add("PresionArterial", "Presión Arterial");
            dgvPacientes.Columns.Add("Categoria", "Categoría");

            dgvPacientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            AgregarRegistrosFicticios();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text) || cmbGenero.SelectedItem == null ||
                cmbTipoSanguineo.SelectedItem == null || cmbPresionArterial.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            var paciente = new Paciente
            {
                Nombre = txtNombre.Text,
                Genero = cmbGenero.SelectedItem.ToString(),
                TipoSanguineo = cmbTipoSanguineo.SelectedItem.ToString(),
                PresionArterial = cmbPresionArterial.SelectedItem.ToString()
            };

            AsignarCategoria(paciente);

            listaPacientes.Add(paciente);

            ClasificarPaciente(paciente);

            LimpiarCampos();

            ActualizarDataGridView();
        }

        private void ClasificarPaciente(Paciente paciente)
        {
            var genero = arbolPacientes.Raiz.Hijos.FirstOrDefault(n => n.Valor == paciente.Genero);
            if (genero != null)
            {
                var tipoSanguineo = genero.Hijos.FirstOrDefault(n => n.Valor == paciente.TipoSanguineo);
                if (tipoSanguineo != null)
                {
                    var presion = tipoSanguineo.Hijos.FirstOrDefault(n => n.Valor == paciente.PresionArterial);
                    if (presion != null)
                    {
                        MessageBox.Show($"Paciente registrado y clasificado en: {genero.Valor} -> {tipoSanguineo.Valor} -> {presion.Valor}");
                    }
                }
            }
        }

        private void AsignarCategoria(Paciente paciente)
        {
            var categorias = new Dictionary<(string genero, string tipoSanguineo, string presionArterial), string>
    {
        { ("Masculino", "A", "Baja"), "Riesgo de Fatiga" },
        { ("Masculino", "A", "Normal"), "Riesgo Cardíaco Moderado" },
        { ("Masculino", "A", "Alta"), "Alto Riesgo Cardiovascular" },
        { ("Masculino", "B", "Baja"), "Riesgo de Fatiga" },
        { ("Masculino", "B", "Normal"), "Riesgo de Diabetes" },
        { ("Masculino", "B", "Alta"), "Alto Riesgo de Diabetes y Cardíaco" },
        { ("Masculino", "AB", "Baja"), "Riesgo de Fatiga" },
        { ("Masculino", "AB", "Normal"), "Riesgo de Enfermedades Renales" },
        { ("Masculino", "AB", "Alta"), "Alto Riesgo Renal y Cardiovascular" },
        { ("Masculino", "O", "Baja"), "Riesgo de Fatiga y Mareos" },
        { ("Masculino", "O", "Normal"), "Bajo Riesgo General" },
        { ("Masculino", "O", "Alta"), "Riesgo Cardiovascular Moderado" },

        { ("Femenino", "A", "Baja"), "Riesgo de Fatiga" },
        { ("Femenino", "A", "Normal"), "Riesgo Cardíaco Moderado" },
        { ("Femenino", "A", "Alta"), "Alto Riesgo Cardiovascular" },
        { ("Femenino", "B", "Baja"), "Riesgo de Fatiga" },
        { ("Femenino", "B", "Normal"), "Riesgo de Diabetes" },
        { ("Femenino", "B", "Alta"), "Alto Riesgo de Diabetes y Cardíaco" },
        { ("Femenino", "AB", "Baja"), "Riesgo de Fatiga" },
        { ("Femenino", "AB", "Normal"), "Riesgo de Enfermedades Renales" },
        { ("Femenino", "AB", "Alta"), "Alto Riesgo Renal y Cardiovascular" },
        { ("Femenino", "O", "Baja"), "Riesgo de Fatiga y Úlceras" },
        { ("Femenino", "O", "Normal"), "Bajo Riesgo General" },
        { ("Femenino", "O", "Alta"), "Riesgo Cardiovascular Moderado" }
    };

            if (categorias.TryGetValue((paciente.Genero, paciente.TipoSanguineo, paciente.PresionArterial), out string categoria))
            {
                paciente.Categoria = categoria;
            }
            else
            {
                paciente.Categoria = "Categoría Desconocida";
            }
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            cmbGenero.SelectedIndex = -1;
            cmbTipoSanguineo.SelectedIndex = -1;
            cmbPresionArterial.SelectedIndex = -1;
        }

        private void ActualizarDataGridView()
        {

            dgvPacientes.Rows.Clear();

            foreach (var paciente in listaPacientes)
            {
                dgvPacientes.Rows.Add(
                    paciente.Nombre,
                    paciente.Genero,
                    paciente.TipoSanguineo,
                    paciente.PresionArterial,
                    paciente.Categoria
                );
            }
        }

        private void AgregarRegistrosFicticios()
        {
            var paciente1 = new Paciente
            {
                Nombre = "Carlos Peña",
                Genero = "Masculino",
                TipoSanguineo = "A",
                PresionArterial = "Alta"
            };
            AsignarCategoria(paciente1);
            listaPacientes.Add(paciente1);

            var paciente2 = new Paciente
            {
                Nombre = "Katherine García",
                Genero = "Femenino",
                TipoSanguineo = "O",
                PresionArterial = "Baja"
            };
            AsignarCategoria(paciente2);
            listaPacientes.Add(paciente2);

            var paciente3 = new Paciente
            {
                Nombre = "Erick Méndez",
                Genero = "Masculino",
                TipoSanguineo = "B",
                PresionArterial = "Normal"
            };
            AsignarCategoria(paciente3);
            listaPacientes.Add(paciente3);

            ActualizarDataGridView();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
