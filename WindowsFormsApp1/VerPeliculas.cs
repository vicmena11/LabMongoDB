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
    public partial class VerPeliculas : Form
    {
        public VerPeliculas()
        {
            InitializeComponent();
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("Peliculas");
            server.Connect();

            var coleccion = database.GetCollection<Pelicula>("Pelicula");
            dgvPelicula.DataSource = coleccion.FindAll().ToList();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VerPeliculas_Load(object sender, EventArgs e)
        {

        }
    }
}
