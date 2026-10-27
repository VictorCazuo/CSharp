using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace IS_AS
{
    public class Produto
    {
        public string Nome { get; set; } = string.Empty;
        private decimal preco;
        public decimal Preco
        {
            get { return preco;}
            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
            }
        }
    }

    public class Livro : Produto
    {
        public string Autor { get; set; } = string.Empty; 
    }

    public class Eletronico : Produto
    {
        public int MesesGarantia { get; set; }
    }


}
