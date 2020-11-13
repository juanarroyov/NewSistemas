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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "Bodeguero")
            {
                Bodega bodega = new Bodega();
                bodega.Show();
            }
            if (txtUsuario.Text == "Cocinero")
            {
                Cocina cocina = new Cocina();
                cocina.Show();
            }
        }
    }
}
