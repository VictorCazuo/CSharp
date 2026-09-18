using System;
using System.Collections.Generic;
using System.Text;

namespace Indexadores
{
    public class Estacionamento
    {
        private string[] vagas = new string[5];

        public string this[int vaga]
        {
            get
            {
                if(vaga >= 0 && vaga < vagas.Length)
                {
                    return vagas[vaga] ?? "Vaga livre";
                }
                return "Vaga inválida";
            }
            set
            {
                if(vaga >= 0 && vaga < vagas.Length)
                {
                    vagas[vaga] = value;
                }
            }
        }
    }


    public class Cardapio
    {
        private string[] produtos = { "Hamburguer", "Batata", "Refrigerante" };
        private double[] precos = { 25.50, 10.00, 8.00 };

        public double this[string nomeProduto]
        {
            get
            {
                for(int i = 0; i < produtos.Length; i++)
                {
                    if(nomeProduto == produtos[i])
                    {
                        return precos[i];
                    }
                }
                return 0.0;
            }
        }
    }

    public class Cinema
    {
        private string[,] assentos = new string[3, 3];

        public string this[int linha, int coluna]
        {
            get
            {
                if (linha >= 0 && coluna >=0 && linha < 3 && coluna < 3)
                {
                    return assentos[linha, coluna] ?? "Livre";
                }

                return "Assento inexistente";
                
            }
            set
            {
                if (linha >= 0 && coluna >= 0 && linha < 3 && coluna < 3)
                {
                    assentos[linha, coluna] = value;
                }
            }

        }
    }
}
