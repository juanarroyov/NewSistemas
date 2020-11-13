﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewSistemaSigloXXI.Modelos
{
    public static class RestHelperCategoria
    {
        private static readonly string baseURL = "http://localhost:9090/";
        public static async Task<string> GetAll()
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(baseURL + "api/categorias"))
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
    public class Categoria
    {
        public int idCategoria { get; set; }
        public string nombreCategoria { get; set; }
       
    }
}
