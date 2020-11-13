using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace NewSistemaSigloXXI.Modelos
{

    public static class RestHelperPlato
    {
        private static readonly string baseURL = "http://localhost:9090/";
        public static async Task<string> GetAll()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/platos"))
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
        public static async Task<string> Get(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/platos/" + id))
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
        public static async Task<string> Post(string nombreplato, int valorplato,
                                                   int tiempo, string preparacion,
                                                   int categoria)
        {
          
            Categoria uni = new Categoria();
            uni.idCategoria = categoria;

            var inputData = new Dictionary<string, string>
            {

                { "nombrePlato", nombreplato },
                {"valorPlato", Convert.ToString(valorplato)},
                {"tiempoPlato", Convert.ToString(tiempo) },
                {"prepPlato", preparacion },
                {"categoria", uni.ToString()}
                //{ "idUnidadMedida", Convert.ToString(unidad)  }


        };

            //var input = new FormUrlEncodedContent(inputData);
            var input = new Plato();
            input.idPlato = 0;
            input.nombrePlato = nombreplato;
            input.valorPlato = valorplato;
            input.tiempoPlato = tiempo;
            input.prepPlato = preparacion;
            input.categoria = uni;


            var json = JsonConvert.SerializeObject(input);
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(baseURL +
                                                        "api/platos", byteContent))
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

        public static async Task<string> Put(int id, string nombreplato, int valorplato,
                                                   int tiempo, string preparacion,
                                                   int catego)
        {
            
            Categoria uni = new Categoria();
            uni.idCategoria = catego;

            var inputData = new Dictionary<string, string>
            {

                {"nombrePlato", nombreplato },
                {"valorPlato", Convert.ToString(valorplato)},
                {"tiempoPlato", Convert.ToString(tiempo) },
                {"prepPlato", preparacion },
                {"categoria", uni.ToString()}
                //{ "idUnidadMedida", Convert.ToString(unidad)  }


        };

            //var input = new FormUrlEncodedContent(inputData);
            var input = new Plato();
            input.idPlato = 0;
            input.nombrePlato = nombreplato;
            input.valorPlato = valorplato;
            input.tiempoPlato = tiempo;
            input.prepPlato = preparacion;
            input.categoria = uni;


            var json = JsonConvert.SerializeObject(input);
            //var stringContent = new HttpStringContent(nombreCategoria);
            //"application/json", json
            var buffer = System.Text.Encoding.UTF8.GetBytes(json);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PutAsync(baseURL + 
                                            "api/platos/" + id, byteContent))
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
        public class Plato
        {
            public int idPlato { get; set; }
            public string nombrePlato { get; set; }
            public int valorPlato { get; set; }
            public int tiempoPlato { get; set; }
            public string prepPlato { get; set; }
            public Categoria categoria { get; set; }



        }
    }


