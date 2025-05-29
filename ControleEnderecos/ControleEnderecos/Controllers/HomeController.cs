using Microsoft.AspNetCore.Mvc;

namespace ControleEnderecos.Controllers
{
    /*Toda página da aplicação DEVE OBRIGATÓRIAMENTE
    estar associado a classe que herde a classe 
    Controller, pois essa classe é um intermedio
    entre as páginas e o back-end da aplicação.*/
    public class HomeController : Controller
    {
        /*Método que vai referência a página
        da área principal do Home*/
        public IActionResult Index()
        {   /*O método View, indica que será retornada
            e visualiza uma página Web*/
            return View();
        }
    }
}