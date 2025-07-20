using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_de_investigacion
{
    public partial class Form1 : Form
    {
        List<string> artistasRegistrados = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string pais = txtPais.Text;
            string genero = txtGenero.Text;
            string album = txtAlbum.Text;
            if (nombre == "" || pais == "" || genero == "" || album == "")
            {
                MessageBox.Show("Por favor llena todos los campos.");
                return;
            }
            string artista = $"🎤 {nombre} | {pais} | {genero} | {album}";
            artistasRegistrados.Add(artista);
            lstArtistas.Items.Add(artista);
            txtNombre.Clear();
            txtPais.Clear();
            txtGenero.Clear();
            txtAlbum.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBusqueda = txtBuscar.Text.ToLower();
            lstArtistas.Items.Clear();

            foreach ( string artista in artistasRegistrados)
            {
                if(artista.ToLower().Contains(textoBusqueda))
                {
                    lstArtistas.Items.Add(artista);
                }
            }
            if (lstArtistas.Items.Count == 0)
            {
                MessageBox.Show("No se encontraron coincidencias.");
            }
        }

        private void btnVerTodos_Click(object sender, EventArgs e)
        {
            lstArtistas.Items.Clear();
            foreach(string artista in artistasRegistrados)
            {
                lstArtistas.Items.Add(artista);
            }
        }

        private void btnHistoria_Click(object sender, EventArgs e)
        {
            Form2 historia = new Form2();
            historia.Show();
        }
    }
}
