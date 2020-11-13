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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewSistemaSigloXXI
{
    public partial class PedidoProveedor : Form
    {
        string url = "http://localhost:9090/api/detallepedidos";
        public static PedidoProveedor Instance;
        public PedidoProveedor()
        {
            Instance = this;
            
            InitializeComponent();
        }

        private void txtPlatos_Click(object sender, EventArgs e)
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

        private async void Cocina_Load(object sender, EventArgs e)
        {
            string respuesta = await GetHttp();
            List<DetallePedido> lst = JsonConvert.DeserializeObject<List<DetallePedido>>(respuesta);
            var nuevalista = lst.Select(x => new
            {
                Id_Pedido = x.pedido.idPedido,
                Fecha = x.pedido.fechaPedido,
                Cantidad_Pedido = x.cantidadDetPed,
                Valor_Producto =(x.provProd == null ? 0 : x.provProd.valorProducto),
                Total_Pedido = x.pedido.totalPedido,
                Id_Proveedor =(x.provProd == null ? 0 :x.provProd.idProvProd),
                Nombre_Proveedor =(x.provProd.prov == null ? " ":x.provProd.prov.nombreProveedor),
                Producto= x.provProd.producto.nombreProducto,
                Stock=x.provProd.producto.stockProducto,
                Stock_Minimo=x.provProd.producto.stockMinimo,
                Usuario = x.pedido.usuario.idUsuario,
                Perfil = x.pedido.usuario.perfil.nombrePerfil
                }).ToList();
            dtgPedidos.DataSource = nuevalista;
        }

        public async Task<string> GetHttp()
        {
            WebRequest oRequest = WebRequest.Create(url);
            WebResponse oResponse = oRequest.GetResponse();
            StreamReader sr = new StreamReader(oResponse.GetResponseStream());
            return await sr.ReadToEndAsync();
        }

        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            var responce = await RestHelperPedido.GetAll();
            
        }
    }
}

