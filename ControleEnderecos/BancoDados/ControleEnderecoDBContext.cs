using ControleEnderecos.Entidades;
using Microsoft.EntityFrameworkCore;
namespace ControleEnderecos.BancoDados
{
    /*Toda classe responsável pela conexão
    com o banco de dados DEVE herdar a classe
    DBContext, pois ele contém todos os métodos
    básicos para manipulação do banco*/
    public class ControleEnderecoDBContext
                : DbContext
    {
        /*O construtor da classe é utilizado para passar a configuração
        do banco de dados, por exemplo, qual banco de dados será
        utilizado.*/
        public ControleEnderecoDBContext(
            DbContextOptions<ControleEnderecoDBContext> options) :
            base(options)
        {
        }
        /*Definindo quais são as tabelas do banco de dados. A classe
        DbSet será responsável por, incluir, excluir, alterar e consultar
        os dados do banco de dados.*/
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Cidade> Cidades { get; set; }
    }
}