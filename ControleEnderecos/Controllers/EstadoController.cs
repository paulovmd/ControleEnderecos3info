using ControleEnderecos.BancoDados;
using ControleEnderecos.Entidades;
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

        /*Esse método é chamado pelo formulário na página HTML
        que está utilizando o Verbo Post, dessa forma, devemos criar
        um método que o formulário HTML está realizando a requisição*/
        [HttpPost]
        public ActionResult InserirEstado(Estado estado)
        {
            //Verifica se foi enviando algum dado pelo formulário HTML
            if (ModelState.IsValid)
            {   
                //Inserindo o Estado na base de dados
                _dbContext.Estados.Add(estado);
            }
            //Retorna para para a página principal do Estado
            return View("Cadastro");
        }


    }

}