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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            txtHistoria.Text = "🎤 El Hip Hop nació en el Bronx, Nueva York, en la década de 1970... \n\n"
                     + "Este género musical no solo es música, sino también cultura. "
                     + "Incluye el rap, el breakdance, el grafiti y el DJing.\n\n"
                     + "Artistas como Tupac, Notorious B.I.G., Nas y muchos otros "
                     + "han marcado su historia.\n\n"
                     + "Hoy en día, el Hip Hop es uno de los géneros más influyentes del mundo.";

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
