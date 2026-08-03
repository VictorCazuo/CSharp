using System;

namespace SeusExercicios
{
    public class ControleDeFluxo
    {
        /// <summary>
        /// 4) O programa deve pedir para o usuário digitar uma palavra e, em seguida, repeti-la na tela.
        /// Ele deve continuar fazendo isso enquanto o usuário não digitar a palavra "sair".
        /// </summary>
        public static void Exercicio4_RepetirPalavra()
        {
            while (true)
            {
                Console.WriteLine("Digite uma palavra: \nDigite (Sair) quando desejar parar.\n");
                string palavra = Console.ReadLine().ToLower();
                if (palavra == "sair") break;

                Console.WriteLine($"{palavra}\n");
            }
        }

        /// <summary>
        /// 5) Crie uma variável string senhaCorreta = "Csharp123".
        /// Peça para o usuário digitar a senha.
        /// Enquanto a senha digitada for diferente da correta, imprima "Senha Incorreta, tente novamente" e peça a senha outra vez.
        /// Quando ele acertar, o while vai quebrar sozinho. Imprima "Cofre Aberto!" fora do loop.
        /// </summary>
        public static void Exercicio5_Senha()
        {
            string senhaCorreta = "Csharp123";
            string senha = "";

            while (senha != senhaCorreta)
            {
                Console.WriteLine("Digite sua senha: \n");
                senha = Console.ReadLine();
                if (senha != senhaCorreta) Console.WriteLine("Senha incorreta.\n");
            }
            Console.WriteLine("Cofre aberto!!");
        }
    }
}