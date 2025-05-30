namespace ControleEnderecos.Entidades
{
    public class Cidade
    {



        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Uf { get; set; } = string.Empty;
        public string Ibge { get; set; } = string.Empty;        
    }
}