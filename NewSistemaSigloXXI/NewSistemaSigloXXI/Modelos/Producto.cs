using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;


namespace NewSistemaSigloXXI.Modelos
{
    public static class RestHelper
    {
        private static readonly string baseURL = "http://localhost:9090/";
        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/productos"))
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
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/productos/" + id))
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
        public static async Task<string> Post(string nombreProduc, double stock, double stockminimo, int unidad)
        {
            //string test = "He said to me, \"Hello World\" . How are you?";
            //const string Comillas = \";
            // string  stringId = @"{""idUnidadMedida"" :" + unidad + "}";
            //var stringId = { "idProducto": ""}
            UnidadMedida uni = new UnidadMedida();
            uni.idUnidadMedida = unidad;

            var inputData = new Dictionary<string, string>
            {

                { "nombreProducto", nombreProduc },
                {"stockProducto", Convert.ToString(stock)},
                {"stockMinimo", Convert.ToString(stockminimo) },
                {"unidad", uni.ToString()}
                //{ "idUnidadMedida", Convert.ToString(unidad)  }


        };

            //var input = new FormUrlEncodedContent(inputData);
            var input = new Producto();
            input.idProducto = 0;
            input.nombreProducto = nombreProduc;
            input.stockProducto = stock;
            input.stockMinimo = stockminimo;
            input.unidad = uni;


            var json = JsonConvert.SerializeObject(input);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL + "api/productos", byteContent))
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

        public static async Task<string> Put(int id, string nombreProduc, double stock, double stockminimo, int unidad)
        {
            //string test = "He said to me, \"Hello World\" . How are you?";
            //const string Comillas = \";
            // string  stringId = @"{""idUnidadMedida"" :" + unidad + "}";
            //var stringId = { "idProducto": ""}
            UnidadMedida uni = new UnidadMedida();
            uni.idUnidadMedida = unidad;

            var inputData = new Dictionary<string, string>
            {

                { "nombreProducto", nombreProduc },
                {"stockProducto", Convert.ToString(stock)},
                {"stockMinimo", Convert.ToString(stockminimo) },
                {"unidad", uni.ToString()}
                //{ "idUnidadMedida", Convert.ToString(unidad)  }


        };

            //var input = new FormUrlEncodedContent(inputData);
            var input = new Producto();
            input.idProducto = id;
            input.nombreProducto = nombreProduc;
            input.stockProducto = stock;
            input.stockMinimo = stockminimo;
            input.unidad = uni;


            var json = JsonConvert.SerializeObject(input);
            //var stringContent = new HttpStringContent(nombreCategoria);
            //"application/json", json
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseURL + "api/productos/" + id , byteContent))
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

        public static string BeautifyJson(string jsonStr)
        {
            JToken parseJson = JToken.Parse(jsonStr);

            return parseJson.ToString(Formatting.Indented);
        }
    }
        public class Producto
    {

        public int idProducto { get; set; }
        public string nombreProducto { get; set; }
        public double stockProducto { get; set; }
        public double stockMinimo { get; set; }
        public UnidadMedida unidad { get; set; }
        //public ICollection<UnidadMedida> unidadMedidas { get; set;}



        }
        

    }


