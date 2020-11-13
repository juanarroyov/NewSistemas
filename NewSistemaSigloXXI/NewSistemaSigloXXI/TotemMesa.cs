using NewSistemaSigloXXI.Modelos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static NewSistemaSigloXXI.Modelos.EstadoMesa;

namespace NewSistemaSigloXXI
{
    public partial class TotemMesa : Form
    {
        public TotemMesa()
        {
            InitializeComponent();
        }

        private void cnbMesa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void TotemMesa_Load(object sender, EventArgs e)
        {

            var respuesta = await RestHelperMesa.GetAll();

            dynamic miarray = JsonConvert.DeserializeObject(respuesta);

            // Recorremos el array de datos del JSON 
            foreach (var item in miarray)
            {
                ComboboxItem item2 = new ComboboxItem
                {
                    Text = item.numeroMesa,
                    Value = item.idMesa

                };
                cnbMesa.Items.Add(item2);
                cnbMesa.SelectedIndex = 0;
                
                
            }
            var respuestaestado = await RestHelperEstadoMesa.GetAll();

            dynamic miarrayestado = JsonConvert.DeserializeObject(respuestaestado);

            // Recorremos el array de datos del JSON 
            foreach (var items in miarrayestado)
            {
                ComboboxItem itemestado = new ComboboxItem
                {
                    Text = items.nombreEstadoMesa,
                    Value = items.idEstadoMesa
                };
                cnbEstado.Items.Add(itemestado);
                cnbEstado.SelectedIndex = 0;
            }
        }

    }
}
