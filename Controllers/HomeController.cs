using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TesteJson.Models;
using TestesSelectPicker.Models;

namespace TesteJson.Controllers
{
    public class HomeController : Controller
    {

 

        public IActionResult Index()
        {
            var ListaCanais = new BuildListCanalDeAtendimento().ListaCanais;            
            return View(ListaCanais);
        }

        [HttpPost]
        public IActionResult SalvarCanal(IEnumerable<CanalDeAtendimento> canais)
        {                        
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Index2()
        {
            List<Contrato> contratos = new BuildContratos().lista;
            ViewBag.Contratos = JsonSerializer.Serialize<List<Contrato>>(contratos);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
