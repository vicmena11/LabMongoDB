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
    public partial class AgregarPelicula : Form
    {
        public AgregarPelicula()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var servidor = mc.GetServer();
                var database = servidor.GetDatabase("Peliculas");
                servidor.Connect();
                var coleccion = database.GetCollection<Pelicula>("Pelicula");
                var pelicula = new Pelicula { nombre = tbNombre.Text, genero = tbGenero.Text, director = tbDirector.Text, franquicia = tbFranquicia.Text, pais = tbPais.Text, annio = int.Parse(tbAño.Text), duracion = int.Parse(tbDuración.Text) ,productora = tbProductora.Text, actores = tbActores.Text.Split(',') };
                coleccion.Insert(pelicula);
                MessageBox.Show("Se registró la película.");
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sucedió un error: "+error);
            }
        }

        private void AgregarPelicula_Load(object sender, EventArgs e)
        {

        }
    }
}
