using NewSistemaSigloXXI.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace NewSistemaSigloXXI
{
    public partial class Plato : Form
    {
        public Plato()
        {
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            var responce = await RestHelperPlato.GetAll();
            txtResponce.Text = RestHelperPlato.BeautifyJson(responce);
        }

        private async void Plato_Load(object sender, EventArgs e)
        {
            var respuesta = await RestHelperCategoria.GetAll();
            
            dynamic miarray = JsonConvert.DeserializeObject(respuesta);

            // Recorremos el array de datos del JSON 
            foreach (var item in miarray)
            {
                ComboboxItem item2 = new ComboboxItem
                {
                    Text = item.nombreCategoria,
                    Value = item.idCategoria
                };
                cmbCategoria.Items.Add(item2);
                cmbCategoria.SelectedIndex = 0;
            }
            
        }

        private async void btnPost_Click(object sender, EventArgs e)
        {
            //Inicialización de variables            
            string nombreplato = txtNombre.Text;
            int valor = Convert.ToInt32(txtValor.Text);
            int tiempo = Convert.ToInt32(txtTiempo.Text);
            string preparacion = txtPreparacion.Text;
            int id = Convert.ToInt32((cmbCategoria.SelectedItem as ComboboxItem).Value.ToString());
            //Realización metodo POST
            var responce = await RestHelperPlato.Post(nombreplato, valor, tiempo, preparacion, id);
            txtResponce.Text = RestHelperPlato.BeautifyJson(responce);
        }

        private async void btnPut_Click(object sender, EventArgs e)
        {
            //Inicialización de variables
            int idplato = Convert.ToInt32(txtID.Text);
            string nombreplato = txtNombre.Text;
            int valor = Convert.ToInt32(txtValor.Text);
            int tiempo = Convert.ToInt32(txtTiempo.Text);
            string preparacion = txtPreparacion.Text;
            int id = Convert.ToInt32((cmbCategoria.SelectedItem as ComboboxItem).Value.ToString());
            //Realización metodo PUT
            var responce = await RestHelperPlato.Put(idplato , nombreplato, valor, tiempo, preparacion, id);
            txtResponce.Text = RestHelperPlato.BeautifyJson(responce);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var responce = await DELETE(id);
            txtID.Text = RestHelperPlato.BeautifyJson(responce);
        }
        private async Task<string> DELETE(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.DeleteAsync("http://localhost:9090/api/platos/" + id))
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

        private void txtVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

