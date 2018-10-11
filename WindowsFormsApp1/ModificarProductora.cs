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
    public partial class ModificarProductora : Form
    {
        public ModificarProductora()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var server = mc.GetServer();
                var database = server.GetDatabase("Peliculas");

                var collection = database.GetCollection<Productora>("Productora");

                var query = Query<Productora>.EQ(productora => productora.nombre, tbNombreBusqueda.Text);

                int año = Convert.ToInt32(tbAño.Text);

                var update = Update<Productora>.Set(productora => productora.año,año);
                collection.Update(query, update);

                update = Update<Productora>.Set(productora => productora.sitioWeb, tbDireccion.Text);
                collection.Update(query, update);


                MessageBox.Show("Los datos fueron actualizados.");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró productora.");
            }
        }
    }
}
