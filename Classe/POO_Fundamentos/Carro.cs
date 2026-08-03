using System;

namespace SeusExercicios.POO
{
    public class Carro
    {
        public string Modelo { get; set; }
        public string Montadora { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public int Potencia { get; set; }
        public int VelocidadeAtual { get; set; } = 0;

        /// <summary>
        /// Exercício Prático 6
        /// x- Crie um campo estático ValorIpva do tipo double que vai definir o valor percentual do IPVA cobrado para todos os carros.
        /// z- (Teoria) O static permite que o método e o campo em questão seja acessado por todos e pertença à classe e não à instância.
        /// </summary>
        public static double ValorIpva { get; set; }

        // --- CONSTRUTORES ---

        public Carro() { }

        public Carro(string modelo, string montadora, string marca, int ano, int potencia)
        {
            Modelo = modelo;
            Montadora = montadora;
            Marca = marca;
            Ano = ano;
            Potencia = potencia;
        }

        /// <summary>
        /// Explique qual o comportamento ao usar este construtor para criar objetos do tipo Carro:
        /// Resposta: Este construtor permite a criação de um objeto (instância) com apenas 2 parâmetros ao invés de passar todos, 
        /// ou seja, se você quiser criar um carro com menos parâmetros, pode usar esse outro construtor e os outros parâmetros
        /// ficam com valor padrão (null para string e 0 para int).
        /// </summary>
        public Carro(string modelo, string montadora)
        {
            Modelo = modelo;
            Montadora = montadora;
        }

        // --- MÉTODOS DE AÇÃO (PRIMEIROS EXERCÍCIOS) ---

        public void Acelerar()
        {
            VelocidadeAtual += 10;
            ExibirVelocidade();
        }

        public void Acelerar(string marcaParametro)
        {
            Console.WriteLine($"Acelerando {marcaParametro}...");
        }

        public void Frear()
        {
            if (VelocidadeAtual > 0)
            {
                VelocidadeAtual -= 10;
                ExibirVelocidade();
            }
            else
            {
                Console.WriteLine("Carro parado");
            }
        }

        public void ExibirVelocidade()
        {
            Console.WriteLine($"Velocidade atual = {VelocidadeAtual}");
        }

        /// <summary>
        /// Explique o comportamento da palavra return:
        /// Resposta: Permite você retornar algum valor que deve ser obrigatoriamente do mesmo tipo que foi declarado na assinatura
        /// do método (ex: int, double, string).
        /// </summary>
        public double VelocidadeMaxima(int potencia)
        {
            return (double)potencia * 1.75;
        }

        // --- EXERCÍCIO PRÁTICO 3 (VALOR, REFERÊNCIA E SOBRECARGA) ---

        /// <summary>
        /// l- Crie um método chamado AumentarPotencia que recebe um parâmetro do tipo int por valor chamado potencia e retorna um int. (incremente 3)
        /// m- (Teoria) Ao passar o argumento pelo valor, ele cria uma cópia da variável, não modificando a original.
        /// </summary>
        public int AumentarPotencia(int potencia)
        {
            potencia = potencia + 3;
            return potencia;
        }

        /// <summary>
        /// n- Crie uma sobrecarga para o método AumentarPotencia que recebe um parâmetro por referência. (incremente 5)
        /// o- (Teoria) A sobrecarga de métodos é quando diferenciamos a assinatura do método, ou seja, a quantidade dos parâmetros ou o tipo deles.
        /// p- (Teoria) Ao passar o argumento por referência, ele cria uma referência para o local da variável padrão, ou seja, se alterarmos a de referência, altera a original.
        /// </summary>
        public int AumentarPotencia(ref int potencia)
        {
            potencia += 5;
            return potencia;
        }

        // --- EXERCÍCIO COM OUT ---

        /// <summary>
        /// Crie um método AumentarPotenciaVelocidade que recebe int potencia e retorna a nova potência. 
        /// Use parâmetro out e passe a variável velocidade que vai retornar a nova velocidade como um double.
        /// s- (Teoria) O parâmetro OUT permite retornar 2 valores em apenas um método. Passa-se o valor por referência igual o REF,
        /// mas não precisa passar o valor no argumento. Um argumento out deve ser inicializado no método chamado antes de retornar.
        /// </summary>
        public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
        {
            potencia += 7;
            velocidade = potencia * 1.75;
            return potencia;
        }

        // --- EXERCÍCIO COM PARÂMETROS OPCIONAIS E NOMEADOS ---

        /// <summary>
        /// t- Crie um método chamado ExibirInfo() que retorna void e exibe as informações dos atributos no console.
        /// u- Defina o parâmetro Ano como opcional.
        /// v- (Teoria) O uso do parâmetro opcional permite omitir o argumento na chamada. 
        /// Argumentos nomeados permitem passar os valores informando explicitamente o nome do parâmetro.
        /// </summary>
        public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 1999)
        {
            Console.WriteLine($"Modelo = {modelo}\nMontadora = {montadora}\nMarca = {marca}\nPotência = {potencia}\nAno = {ano}");
        }

        // --- EXERCÍCIO PRÁTICO 6 (STATIC) ---

        /// <summary>
        /// y- Crie um método estático ObterValorIPVA que atribua o valor 4 ao campo ValorIpva.
        /// </summary>
        public static void ObterValorIPVA()
        {
            ValorIpva = 4;
        }
    }
}