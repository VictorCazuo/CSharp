using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public partial class Produto
    {
        public void AplicarDesconto(decimal porcentagem)
        {
            decimal valorDesconto = (Preco * porcentagem) / 100;
            Preco = Preco - valorDesconto;
        }
    }
}
