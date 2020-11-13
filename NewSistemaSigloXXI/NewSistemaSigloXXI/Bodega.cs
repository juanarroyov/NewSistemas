using NewSistemaSigloXXI.Modelos;
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
        //string url = "http://localhost:9090/api/productos";
        public Bodega()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.GetAll();
            txtId.Text = RestHelper.BeautifyJson(responce);

            //string url = "http://localhost:9090/api/productos";
            //var json = new WebClient().DownloadString(url);

            //var m = JsonConvert.DeserializeObject<List<Producto>>(json);

            //dataGridView1.DataSource = m;
        }

        private async void Bodega_Load(object sender, EventArgs e)
        {
            //string respuesta = await GetHttp();
            //List<Producto> lst = JsonConvert.DeserializeObject<List<Producto>>(respuesta);
            //dgvGet.DataSource = lst;
            //var responce = await RestHelper2.GetAll();
            var respuesta = await RestHelper2.GetAll();
            // List<UnidadMedida> lt_unidadmedida = (List<UnidadMedida>)JsonConvert.DeserializeObject(respuesta);
            // comboBox1.Items.Add(JsonConvert.DeserializeObject(respuesta));
            //UnidadMedida sc = JsonConvert.DeserializeObject<UnidadMedida>(respuesta);

            //Aqui creo una lista para que integre a todos los centros disponibles 
            //List<UnidadMedida> Centro = new List<UnidadMedida>();

            //aqui es donde trato de llenar el combo box mediante la lista y solo añadir el id y su nombre de cada centro 
            //Centro.Add(sc);
            //comboBox1.DataSource = Centro;
            //comboBox1.ValueField = "id";
            //comboBox1.TextField = "Nombres";


            // Deserializamos el archivo 'postres.json' 
            dynamic miarray = JsonConvert.DeserializeObject(respuesta);

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
    }
}
