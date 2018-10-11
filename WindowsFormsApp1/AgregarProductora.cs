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
    public partial class AgregarProductora : Form
    {
        public AgregarProductora()
        {
            InitializeComponent();
        }

        private void AgregarProductora_Load(object sender, EventArgs e)
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
                var coleccion = database.GetCollection<Productora>("Productora");
                var pelicula = new Productora { nombre = tbNombre.Text, año = int.Parse(tbAño.Text), sitioWeb = tbSitioWeb.Text };
                coleccion.Insert(pelicula);
                MessageBox.Show("Se registró productora.");
                this.Hide();
            }
            catch (Exception error)
            {
                MessageBox.Show("Sucedió un error: " + error);
            }
        }
    }
}
