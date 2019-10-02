using System;
using System.Collections.Generic;
using Aula_14___POO.Models;

namespace Aula_14___POO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciamos nossa classe com o método construtor passando os parâmetros
            ProdutoModel produtos = new ProdutoModel(1, "Maçã", "Verde", 3.5);

            // Chamamos um atributo do objeto instanciado
            System.Console.WriteLine(produtos.NomeProduto);

            // Instnciamos nossa classe sem passar parametros utilizando sobrecarga
            ProdutoModel produto_sobrecarga = new ProdutoModel();

            // Alimentamos nosso objeto q estava vazio
            produto_sobrecarga.IdProduto = 1;
            produto_sobrecarga.NomeProduto = "Melão";
            produto_sobrecarga.Descricao = "Amarelo";
            produto_sobrecarga.Preco = 5.50;

            // Chamamos a nossa lista q vai ser do objeto ProdutoModel
            List<ProdutoModel> prod = new List<ProdutoModel>();

            // Adicionamos objetos instanciados e atribuidos em nossa lista
            prod.Add(new ProdutoModel(1, "Cenoura", "Laranja", 2.30));
            prod.Add(new ProdutoModel(2, "Mamão", "Laranja", 2.30));
            prod.Add(new ProdutoModel(3, "Beterraba", "Laranja", 2.30));
            prod.Add(new ProdutoModel(4, "Pastel", "Laranja", 2.30));
            prod.Add(new ProdutoModel(5, "Caldo cana", "Laranja", 2.30));
            prod.Add(new ProdutoModel(6, "Macaco", "Laranja", 2.30));

            // Lemos os dados da nossa lista
            foreach(ProdutoModel p in prod){
                System.Console.WriteLine();
                System.Console.WriteLine(p.IdProduto);
                System.Console.WriteLine(p.NomeProduto);
                System.Console.WriteLine(p.Descricao);
                System.Console.WriteLine(p.Preco);
                System.Console.WriteLine();
            }
            // Chamamos através do indice um elemento específico
            System.Console.WriteLine(prod[4].NomeProduto);
        }
    }
}
