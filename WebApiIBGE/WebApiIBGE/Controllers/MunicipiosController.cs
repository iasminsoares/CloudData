using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApiIBGE.Data;

namespace WebApiIBGE.Controllers
{
    public class MunicipiosController : Controller
    {
        //static async Task<string> GetURI(Uri u)
        //{
        //    var response = string.Empty;
        //    using (var client = new HttpClient())
        //    {
        //        HttpResponseMessage result = await client.GetAsync(u);
        //        if (result.IsSuccessStatusCode)
        //        {
        //            response = await result.Content.ReadAsStringAsync();
        //        }
        //    }

        //    var t = Task.Run(() => GetURI(new Uri("https://servicodados.ibge.gov.br/api/v1/localidades/estados/MG/municipios")));
        //    t.Wait();

        //    Console.WriteLine(t.Result);
        //    Console.ReadLine();

        //    return response;

            
        //}

        
        //public ActionResult Index()
        //{
        //    IEnumerable<Municipios> municipios = null;

        //    using (var client = new HttpClient())
        //    {
        //        //client.BaseAddress = new Uri("https://servicodados.ibge.gov.br/api/v1/localidades/estados/MG/municipios");

        //        ////var response = client.PostAsync("https://servicodados.ibge.gov.br/api/v1/localidades/estados/MG/municipios")
        //        ////new StringContent(json, Encoding.UTF8, "application/json"));

        //       //// var resposta = response.Result.Content.ReadAsStringAsync();
        //       ////Console.WriteLine(resposta);
        //        //HTTP GET
        //        //var response = client.GetAsync("municipios");
        //        //response.Wait();
        //        //var result = response.Result;

        //        //if (result.IsSuccessStatusCode)
        //        //{

        //        //    var readTask = result.Content.ReadAsAsync<Municipios[]>();
        //        //    readTask.Wait();

        //        //    var resultMunicipios = readTask.Result;

        //        //    foreach (var municipio in resultMunicipios)
        //        //    {
        //        //        Console.WriteLine(municipio.Nome);
        //        //    }
        //        //}

        //        //if (result.IsSuccessStatusCode)
        //        //{
        //        //    var readTask = result.Content.ReadAsAsync<IList<Municipios>>();
        //        //    readTask.Wait();
        //        //    municipios = readTask.Result;
        //        //}
        //        //else
        //        //{
        //        //    municipios = Enumerable.Empty<Municipios>();
        //        //    ModelState.AddModelError(string.Empty, "Erro no servidor. Contate o Administrador.");
        //        //}
        //        //return View(municipios);
        //    }
        //}

    }
}
