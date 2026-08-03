using System;

namespace SeusExercicios.POO
{
    /// <summary>
    /// O Upgrade de Hardware (A Regra do Tipo)
    /// O Desafio: Crie duas sobrecargas para um método chamado FazerUpgrade.
    /// Sobrecarga A: Recebe uma string novaPlacaDeVideo.
    /// Sobrecarga B: Recebe um int memoriaRam.
    /// </summary>
    public class ComputadorSetup
    {
        public string FazerUpgrade(string novaPlacaDeVideo)
        {
            return $"Hardware de vídeo atualizado para a {novaPlacaDeVideo}";
        }

        public string FazerUpgrade(int memoriaRam)
        {
            return $"Memória RAM expandida para {memoriaRam} GB.";
        }
    }

    /// <summary>
    /// O Caixa de Supermercado
    /// Classe: Caixa
    /// O Desafio: Crie sobrecargas do método ProcessarPagamento que retornam um bool.
    /// Dinheiro: Recebe decimal valorCompra, decimal valorPago.
    /// Cartão de Crédito: Recebe decimal valorCompra, string numeroCartao (16 caracteres).
    /// Parcelado: Recebe decimal valorCompra, string numeroCartao, int parcelas (entre 2 e 12).
    /// </summary>
    public class Caixa
    {
        public bool ProcessarPagamento(decimal valorCompra, decimal valorPago)
        {
            if (valorPago >= valorCompra)
            {
                decimal troco = valorPago - valorCompra;
                Console.WriteLine($"Valor da Compra: {valorCompra}\nValor Pago: {valorPago}\nTroco: {troco}");
                return true;
            }
            return false;
        }

        public bool ProcessarPagamento(decimal valorCompra, string numeroCartao)
        {
            if (numeroCartao.Length == 16)
            {
                Console.WriteLine($"Pagamento de {valorCompra} aprovado");
                return true;
            }
            return false;
        }

        public bool ProcessarPagamento(decimal valorCompra, string numeroCartao, int parcelas)
        {
            if (parcelas >= 2 && parcelas <= 12)
            {
                decimal valorDaParcela = valorCompra / parcelas;
                Console.WriteLine($"Compra dividida em {parcelas}X de {valorDaParcela:C}");
                return true;
            }
            return false;
        }
    }

    /// <summary>
    /// O Gerador de Consultas SQL (Integração de Sistemas)
    /// Classe: RepositorioEmpresa
    /// O Desafio: Crie sobrecargas do método GerarQueryBusca que retornam uma string (o comando SQL).
    /// Busca por ID (int) e Busca por CNPJ (string).
    /// </summary>
    public class RepositorioEmpresa
    {
        public string GerarQueryBusca(int idEmpresa)
        {
            return $"SELECT * FROM TAB_Empresa WHERE Id = {idEmpresa}";
        }

        public string GerarQueryBusca(string cnpj)
        {
            if (cnpj.Length == 14)
            {
                return $"SELECT * FROM TAB_Empresa WHERE Cnpj = '{cnpj}'";
            }
            return "CNPJ inválido";
        }
    }

    /// <summary>
    /// O Sobrevivente do Eclipse (RPG)
    /// Classe: Personagem
    /// O Desafio: Crie o método ReceberDano com duas sobrecargas:
    /// Dano Físico Padrão (Recebe int danoBase).
    /// Dano Mágico Indefensável (Recebe int danoBase, string tipoMagia).
    /// </summary>
    public class Personagem
    {
        public string Nome { get; set; }
        public int Hp { get; set; } = 100;
        public int Armadura { get; set; } = 20;

        public Personagem(string Nome, int Hp, int Armadura)
        {
            this.Nome = Nome;
            this.Hp = Hp;
            this.Armadura = Armadura;
        }

        public void ReceberDano(int danoBase)
        {
            int danoReal = danoBase - this.Armadura;
            if (danoReal > 0)
            {
                this.Hp -= danoReal;
                Console.WriteLine($"A armadura absorveu uma parte, mas você tomou {danoReal} de dano. HP Restante: {this.Hp}");
            }
            else
            {
                Console.WriteLine("A armadura absorveu todo o impacto!");
            }
        }

        public void ReceberDano(int danoBase, string tipoMagia)
        {
            this.Hp -= danoBase;
            Console.WriteLine($"Ataque de {tipoMagia} ignorou a armadura! Hp atual: {this.Hp}");
        }
    }
}