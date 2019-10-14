using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Controllers
{
    public class ProdutoController : Controller
    {
        private Produto GetProduto()
        {
            return new Produto()
            {
                Id = 1,
                Nome="Xbox One X",
                Descricao = "Jogue em 4K",
                Valor = 200.00M
            };
        }

        public ActionResult Visualizar()
        {
            Produto _produto = GetProduto();
            
            return View(_produto);
            //return new ContentResult() { Content = "<h3>opa</h3>", ContentType = "text/html"};
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}