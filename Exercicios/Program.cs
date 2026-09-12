using System;

namespace AlgoritmosEParams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PORTFÓLIO: LÓGICA COM ARRAYS E PARAMS ===\n");

            Desafio1Faturamento();
            Console.WriteLine(new string('-', 50));

            Desafio2Avaliacoes();
            Console.WriteLine(new string('-', 50));

            Desafio3Crachas();
            Console.WriteLine(new string('-', 50));

            Desafio4Caixa();
            Console.WriteLine(new string('-', 50));

            Desafio5Filtro();
        }

        /// <summary>
        /// Desafio 1: Painel de Vendas (Min e Max)
        /// Objetivo: Varrer um array de faturamentos para encontrar o pico de vendas e o dia de menor movimento.
        /// </summary>
        static void Desafio1Faturamento()
        {
            Console.WriteLine("--- Desafio 1: Painel de Vendas ---");
            decimal[] faturamento = { 1500.50m, 3200.00m, 800.75m, 4100.20m, 2100.00m };

            decimal maiorValor = faturamento[0];
            decimal menorValor = faturamento[0];

            for (int i = 1; i < faturamento.Length; i++)
            {
                if (faturamento[i] > maiorValor)
                {
                    maiorValor = faturamento[i];
                }
                if (faturamento[i] < menorValor)
                {
                    menorValor = faturamento[i];
                }
            }

            Console.WriteLine($"Maior valor = R$ {maiorValor:F2}");
            Console.WriteLine($"Menor valor = R$ {menorValor:F2}");
        }

        /// <summary>
        /// Desafio 2: Avaliação de Atendimento
        /// Objetivo: Calcular a média das notas ignorando valores zerados e evitar divisão por zero.
        /// </summary>
        static void Desafio2Avaliacoes()
        {
            Console.WriteLine("\n--- Desafio 2: Avaliações Válidas ---");
            int[] avaliacoes = { 8, 10, 0, 7, 0, 9 };

            int soma = 0;
            int quantidade = 0;

            for (int i = 0; i < avaliacoes.Length; i++)
            {
                if (avaliacoes[i] > 0)
                {
                    soma += avaliacoes[i];
                    quantidade++;
                }
            }

            if (quantidade > 0)
            {
                Console.WriteLine($"A média válida é = {(double)soma / quantidade:F2}");
            }
            else
            {
                Console.WriteLine("Não existem avaliações válidas.");
            }
        }

        /// <summary>
        /// Desafio 3: Alerta da Catraca (Duplicatas)
        /// Objetivo: Identificar se há crachás duplicados em um lote de acessos.
        /// </summary>
        static void Desafio3Crachas()
        {
            Console.WriteLine("\n--- Desafio 3: Sensor de Catraca ---");
            int[] crachas = { 405, 112, 338, 405, 991 };
            bool encontrouDuplicata = false;

            for (int i = 0; i < crachas.Length; i++)
            {
                for (int y = i + 1; y < crachas.Length; y++)
                {
                    if (crachas[y] == crachas[i])
                    {
                        encontrouDuplicata = true;
                        Console.WriteLine($"[DETALHE] Crachá duplicado encontrado: {crachas[y]}");
                    }
                }
            }

            if (encontrouDuplicata)
            {
                Console.WriteLine("ALERTA: Crachá duplicado encontrado no lote!");
            }
            else
            {
                Console.WriteLine("Tudo ok, sem duplicatas no lote.");
            }
        }

        /// <summary>
        /// Desafio 4: Fechamento de Caixa (Params)
        /// Objetivo: Somar preços dinâmicos recebidos via "params" e aplicar um desconto, evitando saldo negativo.
        /// </summary>
        static void Desafio4Caixa()
        {
            Console.WriteLine("\n--- Desafio 4: PDV Frente de Caixa ---");
            var resultado = Caixa.CalcularFechamento(10.50m, 50m, 20m, 30m);
            var resultado2 = Caixa.CalcularFechamento(5.00m); 


            Console.WriteLine($"Resultado Compra 1: R$ {resultado:F2}");
            Console.WriteLine($"Resultado Compra 2 (Só desconto): R$ {resultado2:F2}");
        }

        /// <summary>
        /// Desafio 5: Filtro de Comentários (Params com Strings)
        /// Objetivo: Buscar a quantidade de vezes que uma palavra aparece em um conjunto dinâmico de frases ignorando Case Sensitive.
        /// </summary>
        static void Desafio5Filtro()
        {
            Console.WriteLine("\n--- Desafio 5: Filtro de Citações ---");
            Console.Write("Digite a palavra-chave que quer buscar (ex: péssimo): ");
            var alvo = Console.ReadLine();

            var resultado = Filtro.ContarCitacoes(alvo, "O serviço foi ótimo", "Péssimo atendimento", "Gostei", "Lugar Péssimo");

            Console.WriteLine($"A palavra '{alvo}' foi citada {resultado} vez(es).");
        }
    }

    // --- CLASSES AUXILIARES ---

    public class Caixa
    {
        public static decimal CalcularFechamento(decimal desconto, params decimal[] precos)
        {
            decimal total = 0;
            foreach (decimal preco in precos)
            {
                total += preco;
            }
            return Math.Max(0, total - desconto);
        }
    }

    public class Filtro
    {
        public static int ContarCitacoes(string palavraAlvo, params string[] frases)
        {
            if (string.IsNullOrWhiteSpace(palavraAlvo)) return 0;

            int soma = 0;
            foreach (string frase in frases)
            {
                if (frase.Contains(palavraAlvo, StringComparison.OrdinalIgnoreCase))
                {
                    soma++;
                }
            }
            return soma;
        }
    }
}