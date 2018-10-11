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
    public partial class Aplicacion : Form
    {
        public Aplicacion()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AgregarPelicula agregarPelicula = new AgregarPelicula();
            agregarPelicula.Show();
        }

        private void verToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerPeliculas verPeliculas = new VerPeliculas();
            verPeliculas.Show();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ModificarPelicula modificarPelicula = new ModificarPelicula();
            modificarPelicula.Show();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarPelicula eliminarPelicula = new EliminarPelicula();
            eliminarPelicula.Show();
        }

        private void productoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AgregarProductora agregarProductora = new AgregarProductora();
            agregarProductora.Show();
        }

        private void verToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            VerProductoras verProductoras = new VerProductoras();
            verProductoras.Show();
        }

        private void eliminarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            EliminarProductora eliminarProductora = new EliminarProductora();
            eliminarProductora.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void porTítuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaTitulo busquedaTitulo = new BusquedaTitulo();
            busquedaTitulo.Show();
        }

        private void oToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaFranquicia busquedaFranquicia = new BusquedaFranquicia();
            busquedaFranquicia.Show();
        }

        private void porRangoDeFechasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaRangoFechas busquedaRangoFechas = new BusquedaRangoFechas();
            busquedaRangoFechas.Show();
        }

        private void todasPelículasDeProductoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaProductora busquedaProductora = new BusquedaProductora();
            busquedaProductora.Show();
        }

        private void estadísticasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarEstadísticas buscarEstadísticas = new BuscarEstadísticas();
            buscarEstadísticas.Show();
        }

        private void modificarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ModificarProductora modificarProductora = new ModificarProductora();
            modificarProductora.Show();
        }
    }
}
