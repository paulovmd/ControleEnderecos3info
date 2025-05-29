//Cria as configurações para preparar
//a aplicação Web
using ControleEnderecos.BancoDados;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

/*Criando um serviço de conexão com banco de dados.
Esse serviço será utilizado para criar a conexão com
o banco de dados de forma automática. Dessa forma, 
não precisamos ficar criando a conexão de forma manual.*/
builder.Services.AddDbContext<ControleEnderecoDBContext>(
     options => options.UseSqlite("Data source = controleenderecos.db"));

/*Permite registar todas as classes Controllers
para que as páginas possar ser associadas a elas, e assim,
utilizas.*/
builder.Services.AddControllers();
builder.Services.AddControllersWithViews();

//o métdo Build inicializa as configurações
//Para que elas possam ser utilizadas no projeto
var app = builder.Build();
//Permite utilizar arquivos como css, javascript e entre outros
app.UseStaticFiles();
//Permite ativar o mapeanto dos endereços das páginas
app.UseRouting();
//Se tiver utilizando controle de usuário, ativa a conexão
//segura para as áreas das páginas
app.UseAuthorization();

//Definindo qual será a página principal  a ser chamada.
app.MapControllerRoute(name: "default",
    pattern : "{controller=Home}/{action=Index}");

app.Run();