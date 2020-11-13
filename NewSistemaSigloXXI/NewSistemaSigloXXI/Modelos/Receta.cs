using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public static class RestHelperReceta
    {
        private static readonly string baseURL = "http://localhost:9090/";
        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/recetas"))
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
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/recetas/" + id))
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

        public static async Task<string> Post(double cantidadReceta, int producto,
                                                       int plato)
        {

            Producto uni = new Producto();
            uni.idProducto = producto;

            Plato idPlatos = new Plato();
            idPlatos.idPlato = plato;

            var inputData = new Dictionary<string, string>
            {

                { "cantidadReceta", Convert.ToString(cantidadReceta) },
                {"producto", Convert.ToString(plato)},
                {"plato", Convert.ToString(plato) }
                
                //{ "idUnidadMedida", Convert.ToString(unidad)  }


        };

            //var input = new FormUrlEncodedContent(inputData);
            var input = new Receta();
            input.idReceta = 0;
            input.cantidadReceta = cantidadReceta;
            input.producto = uni;
            input.plato = idPlatos;


            var json = JsonConvert.SerializeObject(input);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL +
                                                        "api/recetas", byteContent))
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

        public static async Task<string> Put(int id, double cantidadReceta, int producto,
                                                       int plato)
        {

            Producto uni = new Producto();
            uni.idProducto = producto;

            Plato idPlatos = new Plato();
            idPlatos.idPlato = plato;

            var inputData = new Dictionary<string, string>
            {

                {"cantidadReceta", Convert.ToString(cantidadReceta) },
                {"producto", Convert.ToString(plato)},
                {"plato", Convert.ToString(plato) }
                
                //{ "idUnidadMedida", Convert.ToString(unidad)  }


        };

            //var input = new FormUrlEncodedContent(inputData);
            var input = new Receta();
            input.idReceta = 0;
            input.cantidadReceta = cantidadReceta;
            input.producto = uni;
            input.plato = idPlatos;


        

          


            var json = JsonConvert.SerializeObject(input);
            //var stringContent = new HttpStringContent(nombreCategoria);
            //"application/json", json
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseURL +
                                            "api/recetas/" + id, byteContent))
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
    }

    public class Receta
        {
            public int idReceta { get; set; }
            public double cantidadReceta { get; set; }
            public Producto producto { get; set; }
            public Plato plato { get; set; }
        }
    
}
