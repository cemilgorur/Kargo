using Kargo.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Kargo.Connection
{
    class WebApiConn
    {
        HttpClient cl;
        List<Iller> sehirs;
        public WebApiConn()
        {
            cl = new HttpClient();
            sehirs = new List<Iller>();

        }
        async public Task<List<Iller>> SehirAll(string connUrl)
        {   
            using (HttpClient cl = new HttpClient())
            {
                cl.DefaultRequestHeaders.Accept.Clear();
                cl.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                var result = await cl.GetStringAsync("http://172.31.10.87:8080/api/values");

                List<Iller> ils = JsonConvert.DeserializeObject<List<Iller>>(result.ToString());
                return ils;
            }
        } 
    }
}
