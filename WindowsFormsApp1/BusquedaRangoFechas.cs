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
    public partial class BusquedaRangoFechas : Form
    {
        public BusquedaRangoFechas()
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
            int valor = int.Parse(tbAñoInicial.Text);
            int valor2 = int.Parse(tbAñoFinal.Text);
            var resultado = Query<Pelicula>.Where(x => x.annio >= valor && x.annio <= valor2 );
            dgvPelicula.DataSource = coleccion.Find(resultado).ToList();
        }

        private void dgvPelicula_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
