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
    public partial class BuscarEstadísticas : Form
    {
        public BuscarEstadísticas()
        {
            InitializeComponent();
        }

        private void BuscarEstadísticas_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var server = mc.GetServer();
                var database = server.GetDatabase("Peliculas");
                server.Connect();

                MongoCollection<Pelicula> coleccion = database.GetCollection<Pelicula>("Pelicula");

                var resultado = Query<Pelicula>.EQ(u => u.productora, tbProductora.Text);

                var contar = coleccion.Find(resultado).Count();
                var min = coleccion.Find(resultado).SetSortOrder(SortBy.Ascending("duracion")).SetLimit(1).FirstOrDefault();
                var max = coleccion.Find(resultado).SetSortOrder(SortBy.Descending("duracion")).SetLimit(1).FirstOrDefault();
                var filtro = coleccion.Find(resultado);
                double promedio = filtro.Average(x => x.duracion);



                lblCant.Text = contar + "";
                lblMenor.Text = min.duracion + "";
                lblMayor.Text = max.duracion + "";
                lblPromedio.Text = promedio + "";
            }
            catch (Exception error)
            {

            }
        }
    }
}
