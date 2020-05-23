using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RBIntegracaoFront.Viwer.Services
{
    public class ServiceUsuario
    {
       
        static HttpClient client = new HttpClient();
        static string formatoJson = "application/json";


        static async Task RunAsync()
        {
            client.BaseAddress = new Uri("http://localhost:5000/api/Usuario/");
        }
        public async Task<Uri> AdicionarUsuario(Models.Usuario usuario)
         {
            try
            {              

                await RunAsync();
                var jsonContent = JsonConvert.SerializeObject(usuario);
                var contentString = new StringContent(jsonContent, Encoding.UTF8, formatoJson);

                contentString.Headers.ContentType = new
                MediaTypeHeaderValue(formatoJson);
             //   contentString.Headers.Add("Session-Token", session_token);


                var response = await client.PostAsync("Adicionar", contentString);

                var teste = response.RequestMessage;
                
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
