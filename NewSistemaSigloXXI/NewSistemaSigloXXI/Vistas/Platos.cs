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
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;

namespace NewSistemaSigloXXI
{
    public partial class Platos : Form
    {
        string url = "http://localhost:9090/api/platos/";
        public Platos()
        {
            //this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private async void btnGet_Click(object sender, EventArgs e)
        {
            // string resp = await GetHttp();

            int id = Convert.ToInt32(txtID.Text);
            var resonce = await RestHelperPlato.Get(id);
            List<Plato> lst = JsonConvert.DeserializeObject<List<Plato>>(resonce);
            var nuevalista = lst.Select(x => new {
                ID = x.idPlato,
                Nombre_Plato = x.nombrePlato,
                Valor = x.valorPlato,
                Tiempo = x.tiempoPlato,
                Preparacion = x.prepPlato,
                Categoria = x.categoria.nombreCategoria
            }).ToList();
            dtgLoad.DataSource = nuevalista;

        }

        private async void Plato_Load(object sender, EventArgs e)
        {
            string grid = await GetHttp();
            List<Plato> lst = JsonConvert.DeserializeObject<List<Plato>>(grid);
            var nuevalista = lst.Select(x => new { ID = x.idPlato, Nombre_Plato = x.nombrePlato, 
                    Valor = x.valorPlato, Tiempo = x.tiempoPlato, Preparacion = x.prepPlato, 
                    Categoria = x.categoria.nombreCategoria }).ToList();
            dtgLoad.DataSource = nuevalista;

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
            try
            {
                //Inicialización de variables
                string nombreplato = txtNombre.Text;
                int valor = Convert.ToInt32(txtValor.Text);
                int tiempo = Convert.ToInt32(txtTiempo.Text);
                string preparacion = txtPreparacion.Text;
                int id = Convert.ToInt32((cmbCategoria.SelectedItem as ComboboxItem).Value.ToString());
                //Realización metodo POST
                var responce = await RestHelperPlato.Post(nombreplato, valor, tiempo, preparacion, id);
                //txtResponce.Text = RestHelperPlato.BeautifyJson(responce);
            }
            catch (Exception)
            {
                MessageBox.Show("ingrese los datos faltantes");
                
            }//Inicialización de variables            
            
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
            //txtResponce.Text = RestHelperPlato.BeautifyJson(responce);
        }

       /* private async Task<string> DELETE(int id)
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

        /*private async void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtID.Text);
            var responce = await DELETE(id);
            txtID.Text = RestHelperPlato.BeautifyJson(responce);
        }*/
        

        private void txtVolver_Click(object sender, EventArgs e)
        {
            PedidoProveedor openPage02 = new PedidoProveedor();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }
        /*public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }*/
       public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtTiempo_KeyPress(object sender, KeyPressEventArgs e)
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
    }
    }

