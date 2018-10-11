using MongoDB.Bson;
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
    public partial class EliminarPelicula : Form
    {
        public EliminarPelicula()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "") {
                try
                {
                    var conexion = "mongodb://localhost";
                    var mc = new MongoClient(conexion);
                    var server = mc.GetServer();
                    var database = server.GetDatabase("Peliculas");
                    server.Connect();

                    var coleccion = database.GetCollection<Pelicula>("Pelicula");
                    string nombre = tbNombre.Text;
                    var query = Query<Pelicula>.EQ(pelicula => pelicula.nombre, nombre);
                    coleccion.Remove(query);
                    MessageBox.Show("Película eliminada.");
                    this.Hide();
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ocurrió un error: " + error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese el nombre de una película.");
            }
        }
    }
}
