using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using static NewSistemaSigloXXI.Modelos.RestHelperProveedor;

namespace NewSistemaSigloXXI.Modelos
{

    public static class RestHelperProveedorProducto
    {
        private static readonly string baseURL = "http://localhost:9090/";
        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/proveedorproductos"))
                {
                    using (HttpContent content = res.Content)
                    {
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
        public static async Task<string> Get(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/proveedorproductos/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
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


        public class ProveedorProducto
        {
            public int idProvProd { get; set; }
            public int valorProducto { get; set; }
            public Proveedor prov { get; set; }
            public Producto producto { get; set; }

        }
    }
}
