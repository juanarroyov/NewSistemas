using NewSistemaSigloXXI.Modelos;
using NewSistemaSigloXXI.Vistas;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace NewSistemaSigloXXI
{
    public partial class Bodega : Form
    {
        string url = "http://localhost:9090/api/productos";
        public Bodega()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var response = await RestHelper.Get(id);
            Producto lst = JsonConvert.DeserializeObject<Producto>(response);
            /* */
            List<Producto> listaTemp = new List<Producto>();
            listaTemp.Add(lst);
            var nuevalista = listaTemp.Select(x => new
            {
                Id_Producto = x.idProducto,
                Nombre_Producto = x.nombreProducto,
                Stock_Producto = x.stockProducto,
                Stock_Minimo = x.stockMinimo,
                Categoria_Producto = x.unidad.nombreUnidadMedida
            }).ToList();
            dataGridView1.DataSource = nuevalista;
            dataGridView1.Refresh();

            //string url = "http://localhost:9090/api/productos";
            //var json = new WebClient().DownloadString(url);

            //var m = JsonConvert.DeserializeObject<List<Producto>>(json);

            //dataGridView1.DataSource = m;
        }

        private async void Bodega_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
            var nuevalista = lst.Select(x => new
            {
                Id_Producto = x.idProducto,
                Nombre_Producto = x.nombreProducto,
                Stock_Producto = x.stockProducto,
                Stock_Minimo = x.stockMinimo,
                Categoria_Producto = x.unidad.nombreUnidadMedida
            }).ToList();
            dataGridView1.DataSource = nuevalista;
            var respuestas = await RestHelper2.GetAll();
            //var response = await RestHelper2.GetAll();

            // List<UnidadMedida> lt_unidadmedida = (List<UnidadMedida>)JsonConvert.DeserializeObject(respuesta);
            // comboBox1.Items.Add(JsonConvert.DeserializeObject(respuesta));
            //UnidadMedida sc = JsonConvert.DeserializeObject<UnidadMedida>(respuesta);

            //Aqui creo una lista para que integre a todos los centros disponibles 
            //List<UnidadMedida> Centro = new List<UnidadMedida>();

           // Deserializamos el archivo 'postres.json' 
            dynamic miarray = JsonConvert.DeserializeObject(respuestas);

            // Recorremos el array de datos del JSON 
            foreach (var item in miarray)
            {
                ComboboxItem item2 = new ComboboxItem
                {
                    Text = item.nombreUnidadMedida,
                    Value = item.idUnidadMedida
                };
                comboBox1.Items.Add(item2);
                comboBox1.SelectedIndex = 0;
            }
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            //Inicialización de variables            
            string nombre = txtNombre.Text;
            double stock = Convert.ToDouble(txtStock.Text);
            double minimo = Convert.ToDouble(txtMinimo.Text);
            int id = Convert.ToInt32((comboBox1.SelectedItem as ComboboxItem).Value.ToString());
            //Realización metodo POST
            var responce = await RestHelper.Post(nombre, stock, minimo, id);
            txtId.Text = RestHelper.BeautifyJson(responce);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            double stock = Convert.ToDouble(txtStock.Text);
            double minimo = Convert.ToDouble(txtMinimo.Text);
            int id = Convert.ToInt32((comboBox1.SelectedItem as ComboboxItem).Value.ToString());
            int idproducto = Convert.ToInt32(txtId.Text);


            var responce = await RestHelper.Put(idproducto, nombre, stock, minimo, id);
            txtId.Text = RestHelper.BeautifyJson(responce);
        }
        private async Task<string> DELETE(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:9090/api/productos/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        MessageBox.Show(res.StatusCode.ToString());
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }

            }
            return string.Empty;
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            var responce = await DELETE(id);
            txtId.Text = RestHelper.BeautifyJson(responce);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtMinimo.Text = "";
            txtNombre.Text = "";
            txtStock.Text = "";
            
        }

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as System.Windows.Controls.TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            
        }

        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void txtMinimo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            PedidoProveedor openPage02 = new PedidoProveedor();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        private void txtId_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        private void txtMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                    (e.KeyChar != '.'))
                {
                    e.Handled = true;
                }

                // only allow one decimal point
                if ((e.KeyChar == '.') && ((sender as System.Windows.Forms.TextBox).Text.IndexOf('.') > -1))
                {
                    e.Handled = true;
                }
            }
        }

        

        

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            string message = "¿Desea Cerrar Sesión?";
            string title = "Cerrar Sesión";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                Login openPage02 = new Login();
                this.Hide();
                openPage02.ShowDialog();
                this.Close();
            }
            else
            {
                // Do something  
            }
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
