using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSistemaSigloXXI
{
    public partial class Cocina : Form
    {
        public Cocina()
        {
            InitializeComponent();
        }

        private void txtPlatos_Click(object sender, EventArgs e)
        {
            Plato plato = new Plato();
            plato.Show();
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            Receta receta = new Receta();
            receta.Show();
        }
    }
}
