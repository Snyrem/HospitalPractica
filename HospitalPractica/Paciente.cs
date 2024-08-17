using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalPractica
{
    public partial class Paciente : Form
    {
        private readonly BaseDatos db = new BaseDatos();
        public Paciente()
        {
            InitializeComponent();
            LoadPaciente();
        }
        //--------------------------------------------------------------------------------------------------------------------
        //
        //Aqui cargamos nuestra informacion de nuestras tablas de la base de datos que hemos creado anteriormente.
        //
        //--------------------------------------------------------------------------------------------------------------------
        private void LoadPaciente()
        {
            string query = "SELECT * FROM Paciente";
            DataTable pacientes = db.ExecuteQuery(query);
            dgvPaciente.DataSource = pacientes;
        }
        private void dgvPaciente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        //--------------------------------------------------------------------------------------------------------------------
        //
        //Al igual que los otros botones de agregar este se encargara objetivamente de lo mismo como tal ya que agregara los datos
        //que definen a un paciente para ser identificado con caracteristicas unicas de otros y tener una mucha mejor organizacion de
        //todos nuestros datos en nuestro programa y base de datos.
        //
        //--------------------------------------------------------------------------------------------------------------------
        {
            string query = "INSERT INTO Paciente (Nombre, FechaNacimiento, Telefono, Domicilio ) VALUES (@Nombre, @FechaNacimiento, @Telefono, @Domicilio";
            SqlParameter[] parameters =
            {
                new SqlParameter("@Nombre", txtNombre.Text),
                new SqlParameter("@FechaNacimiento", dtpFechaDeNacimiento.Value),
                new SqlParameter("@Telefono", txtTelefono.Text),
                new SqlParameter("@Domicilio", txtDomicilio.Text)
            };

            db.ExecuteNonQuery(query, parameters);
            LoadPaciente();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }
    }
}
