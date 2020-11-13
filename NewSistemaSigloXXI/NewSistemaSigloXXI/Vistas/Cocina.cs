using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSistemaSigloXXI.Vistas
{
    public partial class Cocina : Form
    {
        public Cocina()
        {
            InitializeComponent();
        }

        private void btnPlatos_Click(object sender, EventArgs e)
        {
            Platos openPage02 = new Platos();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        private void btnReceta_Click(object sender, EventArgs e)
        {
            Recetas openPage02 = new Recetas();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }
    }
}
