using NewSistemaSigloXXI.Vistas;
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
        public static Login Instance;


        public Login()
        {
            Instance = this;
            InitializeComponent();
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtUsuario.Text == "Bodeguero" && txtPass.Text == "1234")
            {
                Bodega openPage02 = new Bodega();
                this.Hide();
                openPage02.ShowDialog();
                this.Close();
            }
            else if (txtUsuario.Text == "Cocinero" && txtPass.Text == "1234")
            {

                Cocina openPage02 = new Cocina();
                this.Hide();
                openPage02.ShowDialog();
                this.Close();

            }
            else
            {
                MessageBox.Show("Usuario y/o contraseña incorrecta");
            }
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
