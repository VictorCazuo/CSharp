using System;

namespace SeusExercicios
{
    public class SistemasInterativos
    {
        /// <summary>
        /// 8) Crie uma variável int numeroSecreto = 42;.
        /// Peça para o usuário adivinhar o número.
        /// Enquanto ele não acertar, o programa deve dar dicas:
        /// Se o chute for maior que 42, imprima "O número secreto é MENOR. Tente de novo:." 
        /// Se o chute for menor, imprima "O número secreto é MAIOR. Tente de novo:." 
        /// Quando ele acertar, imprima "Parabéns, você acertou!."
        /// </summary>
        public static void Exercicio8_AdivinharNumero()
        {
            int numeroSecreto = 42;
            while (true)
            {
                Console.WriteLine("Adivinha o número secreto: \n");
                int resposta = Convert.ToInt32(Console.ReadLine());

                if (resposta == numeroSecreto)
                {
                    Console.WriteLine("Parabéns, você acertou!");
                    break;
                }
                else if (resposta < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é MAIOR. Tente de novo: \n");
                }
                else
                {
                    Console.WriteLine("O número secreto é MENOR. Tente de novo: \n");
                }
            }
        }

        /// <summary>
        /// 9) Crie um menu: "1 - Cadastrar | 2 - Ver Perfil | 3 - Sair".
        /// Leia a opção do usuário e use um switch para responder à ação escolhida.
        /// Coloque toda essa lógica de mostrar o menu e ler a opção dentro de um while. 
        /// O loop só deve ser encerrado (usando uma condição falsa ou o comando break) quando a opção for 3.
        /// </summary>
        public static void Exercicio9_Menu()
        {
            while (true)
            {
                Console.WriteLine("Digite (1 - Cadastrar | 2 - Ver Perfil | 3 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1: Console.WriteLine("Entrando no cadastro..."); break;
                    case 2: Console.WriteLine("Entrando no perfil..."); break;
                    case 3: Console.WriteLine("Saindo..."); break;
                    default: Console.WriteLine("Digite uma opção válida"); break;
                }

                if (opcao == 3) break;
            }
        }

        /// <summary>
        /// 10) O usuário tem um double saldo = 1000.00;.
        /// Inicie um loop pedindo: "Quanto você deseja sacar? (Digite 0 para sair)".
        /// Regras dentro do loop:
        /// Se ele pedir mais do que tem no saldo, avise "Saldo Insuficiente" e não desconte.
        /// Se tiver saldo, subtraia o valor e mostre o novo saldo.
        /// O loop deve continuar enquanto a opção digitada for diferente de 0 E o saldo for maior que 0.
        /// Se o saldo zerar, imprima "Sua conta está zerada!" e o programa deve fechar automaticamente.
        /// </summary>
        public static void Exercicio10_Saque()
        {
            double saldo = 1000.00;
            double sacar = -1;

            while (sacar != 0 && saldo > 0)
            {
                Console.WriteLine($"\nSaldo: {saldo:C}. Quanto deseja sacar? (0 para sair)");
                sacar = Convert.ToDouble(Console.ReadLine());

                if (sacar == 0)
                {
                    Console.WriteLine("Saindo do sistema...");
                    break;
                }

                if (sacar > saldo)
                {
                    Console.WriteLine("Saldo insuficiente!");
                }
                else
                {
                    saldo -= sacar;
                    Console.WriteLine("Saque realizado.");
                }
            }

            if (saldo <= 0) Console.WriteLine("Sua conta está zerada!");
        }
    }
}