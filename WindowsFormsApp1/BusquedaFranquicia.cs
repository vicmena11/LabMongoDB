using MongoDB.Driver;
using MongoDB.Driver.Builders;
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
    public partial class BusquedaFranquicia : Form
    {
        public BusquedaFranquicia()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string conexion = "mongodb://localhost";
            var mc = new MongoClient(conexion);
            var server = mc.GetServer();
            var database = server.GetDatabase("Peliculas");
            server.Connect();

            MongoCollection<Pelicula> coleccion = database.GetCollection<Pelicula>("Pelicula");
            var resultado = Query<Pelicula>.EQ(u => u.franquicia, tbFranquicia.Text);
            dgvPelicula.DataSource = coleccion.Find(resultado).ToList();
        }
    }
}
