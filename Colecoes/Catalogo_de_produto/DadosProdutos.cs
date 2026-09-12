using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Catalogo_de_produto
{
    public class DadosProdutos
    {

        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto() { Nome = "Mouse", Preco = 50.00},
                new Produto() { Nome = "Teclado", Preco = 120.00},
                new Produto() { Nome = "Monitor", Preco = 800.00},
                new Produto() { Nome = "Headset", Preco = 200.00},
                new Produto() { Nome = "Mousepad", Preco = 30.00}
            };

            return produtos;
        }
    }
}
