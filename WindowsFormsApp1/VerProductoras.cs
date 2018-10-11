using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VerProductoras : Form
    {
        public VerProductoras()
        {
            InitializeComponent();
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("Peliculas");
            server.Connect();

            var coleccion = database.GetCollection<Productora>("Productora");
            dgvProductoras.DataSource = coleccion.FindAll().ToList();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VerProductoras_Load(object sender, EventArgs e)
        {

        }
    }
}
