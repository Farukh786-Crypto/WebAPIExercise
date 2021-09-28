using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DemoRestClientConsole
{
    class DemoRestClientModel
    {
        private string BASE_URL = "https://localhost:44316/api/Demo/demo1/";

        public Task<HttpResponseMessage> Demo1()
        {
            try
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri(BASE_URL);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));
                return client.GetAsync("demo1");
            }
            catch
            {
                return null;
            }
        }
    }
}
