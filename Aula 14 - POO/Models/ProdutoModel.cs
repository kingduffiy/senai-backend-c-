namespace Aula_14___POO.Models
{
    public class ProdutoModel
    {
        public int IdProduto { get; set; }

        public string NomeProduto { get; set; }

        public string Descricao { get; set; }

        public double Preco { get; set; }

        // Utilizamos sobrecarga para poder instanciar passando ou não os atributos/parametros/argumentos
        public ProdutoModel(){

        }

        public ProdutoModel(int idproduto, string nomeproduto, string descricao, double preco){
            this.IdProduto = idproduto;
            this.NomeProduto = nomeproduto;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        
    }
}