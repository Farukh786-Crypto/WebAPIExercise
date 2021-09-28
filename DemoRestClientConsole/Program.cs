using System;
using System.Net;
using System.Net.Http;

namespace DemoRestClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoRestClientModel demoRestClientModel = new DemoRestClientModel();

            HttpResponseMessage httpResponseMessage = demoRestClientModel.Demo1().Result;

            HttpStatusCode httpStatusCode = httpResponseMessage.StatusCode;
            Console.WriteLine("Status Code: " + httpStatusCode);

            bool isSuccessStatusCode = httpResponseMessage.IsSuccessStatusCode;
            Console.WriteLine("IsSuccessStatusCode: " + isSuccessStatusCode);

            string result = httpResponseMessage.Content.ReadAsStringAsync().Result;
            Console.WriteLine("Result: " + result);

            Console.ReadLine();
        }
    }
}
