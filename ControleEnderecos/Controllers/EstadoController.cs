using ControleEnderecos.BancoDados;
using Microsoft.AspNetCore.Mvc;

namespace ControleEnderecos.Controllers
{
    public class EstadoController : Controller
    {
        //Declarando a referência para o objeto responsável
        //pela conexão com o banco de dados
        private ControleEnderecoDBContext _dbContext;

        /*Toda classe controller DEVE criar um construtor que recebe
        como referência a instância da classe responsável pela conexão
        com o banco de dados.*/
        public EstadoController(ControleEnderecoDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        /*Método que referência a pagína Index.cshtml da área do 
        Estado. Neste caso, toda página que for criada no controller
        DEVE possuir um método com o mesmo Nome.*/
        public ActionResult Index()
        {
            
            
            return View();
        }
        /*Método que referência a página de cadastro dos estados.
        Devemos criar uma página Cadastro.cshtml na pasta Views/Estado*/
        public ActionResult Cadastro()
        {
            return View();
        }


    }

}