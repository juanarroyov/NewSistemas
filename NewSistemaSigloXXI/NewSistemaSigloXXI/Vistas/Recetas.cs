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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSistemaSigloXXI.Vistas
{
    
    public partial class Recetas : Form
    {
        string url = "http://localhost:9090/api/recetas";
        public Recetas()
        {
            InitializeComponent();
        }

        private async void Recetas_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<Receta> lst = JsonConvert.DeserializeObject<List<Receta>>(respuesta);
            var nuevalista = lst.Select(x => new 
            {Id_Receta= x.idReceta,
             Cantidad_Producto = x.cantidadReceta,
             Producto= (x.producto ==  null ? "": x.producto.nombreProducto),
             Plato =(x.plato == null ? "": x.plato.nombrePlato),
             Preparacion = x.plato.prepPlato
            }).ToList();
            dtgReceta.DataSource = nuevalista;

            var respuestass = await RestHelper.GetAll();

            dynamic miarray = JsonConvert.DeserializeObject(respuestass);

            // Recorremos el array de datos del JSON 
            foreach (var item in miarray)
            {
                ComboboxItem item2 = new ComboboxItem
                {
                    Text = item.nombreProducto,
                    Value = item.idProducto
                };
                cmbProducto.Items.Add(item2);
                cmbProducto.SelectedIndex = 0;
            }
            var respuestasa = await RestHelperPlato.GetAll();

            dynamic miarray2 = JsonConvert.DeserializeObject(respuestasa);

            // Recorremos el array de datos del JSON 
            foreach (var item3 in miarray2)
            {
                ComboboxItem item4 = new ComboboxItem
                {
                    Text = item3.nombrePlato,
                    Value = item3.idPlato
                };
                cmbPlato.Items.Add(item4);
                cmbPlato.SelectedIndex = 0;
            }
        }

        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Cocina openPage02 = new Cocina();
            this.Hide();
            openPage02.ShowDialog();
            this.Close();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            double cantidad = Convert.ToDouble(txtCantidad.Text);
            int idplato = Convert.ToInt32((cmbPlato.SelectedItem as ComboboxItem).Value.ToString());
            int idProducto = Convert.ToInt32((cmbProducto.SelectedItem as ComboboxItem).Value.ToString());
            //Realización metodo POST
            var responce = await RestHelperReceta.Post(cantidad, idProducto, idplato);
            dtgReceta.Refresh();

        }
    }
    
    }

