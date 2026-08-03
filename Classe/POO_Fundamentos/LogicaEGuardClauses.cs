using System;

namespace SeusExercicios.POO
{
    /// <summary>
    /// O Avaliador de Treino (Muay Thai)
    /// Classe: Lutador
    /// Propriedades: Nome(string), Energia(int), EstaLesionado(bool).
    /// O Desafio: Crie um método chamado AvaliarCondicao() que retorna uma string.
    /// Se o lutador estiver lesionado, retorne imediatamente "Inapto para treinar".
    /// Se não estiver lesionado, mas a energia for menor que 40, retorne "Treino leve de manopla".
    /// Se a energia for 40 ou mais, retorne "Pronto para o sparring!".
    /// Regra: Tente fazer isso sem usar a palavra else. Use apenas if e return (Guard Clause)!
    /// </summary>
    public class Lutador
    {
        public string Nome { get; set; }
        public int Energia { get; set; }
        public bool EstaLesionado { get; set; }

        public Lutador(string Nome, int Energia, bool EstaLesionado)
        {
            this.Nome = Nome;
            this.Energia = Energia;
            this.EstaLesionado = EstaLesionado;
        }

        public string AvaliarCondicao()
        {
            if (this.EstaLesionado) return "Inapto para treinar";
            if (this.Energia < 40) return "Treino leve de manopla";

            return "Pronto para o sparring";
        }
    }

    /// <summary>
    /// O Calculador de Gargalo (Hardware)
    /// Classe: Computador
    /// O Desafio: Crie um método chamado CalcularGargalo que receba dois parâmetros: int usoCpu e int usoGpu.
    /// Se CPU 100 e GPU menor que 70, retorne "Gargalo de CPU detectado!".
    /// Se GPU 100 e CPU menor que 70, retorne "Gargalo de GPU detectado!".
    /// Qualquer outro cenário, retorne "Sistema equilibrado".
    /// </summary>
    public class Computador
    {
        public string CalcularGargalo(int usoCpu, int usoGpu)
        {
            if (usoCpu == 100 && usoGpu < 70) return "Gargalo de CPU detectado";
            if (usoCpu < 70 && usoGpu == 100) return "Gargalo de GPU detectado!";

            return "Sistema equilibrado";
        }
    }

    /// <summary>
    /// O Sistema de Controle de Acesso (Catraca)
    /// A Regra de Negócio: Crie uma classe chamada CatracaOcr. Nela, crie um método chamado LiberarAcesso.
    /// Se a placa recebida for vazia (use placaVeiculo == ""), retorne false.
    /// Se o objeto Aluno for passado, imprima no console e retorne true.
    /// </summary>
    public class CatracaOcr
    {
        public bool LiberarAcesso(string placaVeiculo, Aluno aluno)
        {
            if (placaVeiculo == "") return false;

            if (aluno != null)
            {
                Console.WriteLine($"Acesso da placa {placaVeiculo} liberado para {aluno.nome}");
                return true;
            }

            return false;
        }
    }
}