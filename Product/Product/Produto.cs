using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Product
{
    class Produto
    { 
        private string _nome;      // Private por padrão começa com _ e letra minuscula, já o public é maiuscula 
        public double Preco {get; private set;}
        public int Quantidade {get; private set;}

    public Produto(){}

 //Construtores = Permitir ou obrigar que o objeto receba dados / dependências no momento de sua instanciação(injeção de dependência)
       public Produto(string nome, double preco, int quantidade)         {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;

        }
  /*      public Produto(string nome, double preco) // SobreCarga = usar uma função para fazer a mesma coisa só que com parametros diferentes
        {
           this._nome = nome; // this usado atributo da classes
            _preco = preco;
            _quantidade = 0;
        }
        public Produto() // CONSTRUTOR PADRÃO
        {
        } */


        public string Nome{
           get { 
           return _nome; 
           }
            set {
                if (value != null && value.Length > 1)  //value = nome
                {
                    _nome = value;
                }
                else { 
                    Console.WriteLine("Nome inválido"); 
                }
            }
        }


        public double ValorTotalEmEstoque() //Funções
        {
            return Preco * Quantidade; 
        }
        public void AdicionarProdutos(int quantidade)//Funções
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)//Funções
        {
            Quantidade -= quantidade;
        }
        public override string ToString() //Código para concatenar textos de forma padrão
        {
            return _nome
                + ", $"
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $"
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
