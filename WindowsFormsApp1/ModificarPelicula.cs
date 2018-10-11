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
    public partial class ModificarPelicula : Form
    {
        public ModificarPelicula()
        {
            InitializeComponent();
           
        }
        
        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                string conexion = "mongodb://localhost";
                var mc = new MongoClient(conexion);
                var server = mc.GetServer();
                var database = server.GetDatabase("Peliculas");

                var collection = database.GetCollection<Pelicula>("Pelicula");

                var query = Query<Pelicula>.EQ(pelicula => pelicula.nombre, tbNombreBusqueda.Text);
                

                var update = Update<Pelicula>.Set(pelicula => pelicula.genero, tbGenero.Text);
                collection.Update(query, update);

                update = Update<Pelicula>.Set(pelicula => pelicula.director, tbDirector.Text);
                collection.Update(query, update);

                update = Update<Pelicula>.Set(pelicula => pelicula.franquicia, tbFranquicia.Text);
                collection.Update(query, update);

                update = Update<Pelicula>.Set(pelicula => pelicula.pais, tbPais.Text);
                collection.Update(query, update);

                int año = Convert.ToInt32(tbAño.Text);

                update = Update<Pelicula>.Set(pelicula => pelicula.annio, año);
                collection.Update(query, update);

                int duracion = Convert.ToInt32(tbDuración.Text);

                update = Update<Pelicula>.Set(pelicula => pelicula.duracion, duracion);
                collection.Update(query, update);

                update = Update<Pelicula>.Set(pelicula => pelicula.productora, tbProductora.Text);
                collection.Update(query, update);

                update = Update<Pelicula>.Set(pelicula => pelicula.actores, tbActores.Text.Split(','));
                collection.Update(query, update);

                MessageBox.Show("Los datos fueron actualizados.");
                this.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("No se encontró película.");
            }
        
        }
    }
}
