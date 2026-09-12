using Simulacao_RH;
using System.Security.Cryptography.X509Certificates;

namespace Simulacao_RH
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Funcionario> funcionarios = DadosColaboradores.GetFuncionarios();
            ExibirInformacoes(funcionarios);

            funcionarios.Add(new Funcionario { Nome = "Camila", Salario = 4500.00 });
            funcionarios.Add(new Funcionario { Nome = "Thiago", Salario = 2900.00 });

            //Lista atualizada depois de adicionar os funcionários
            Console.WriteLine("\nLista com os novos funcionários\n");
            ExibirInformacoes(funcionarios);

            //Demissão de funcionário
            Console.WriteLine("\nLista depois da demissão\n");
            funcionarios.RemoveAll(f => f.Nome == "Felipe");
            ExibirInformacoes(funcionarios);

            //Ordenar lista de funcionários em ordem alfabética
            Console.WriteLine("\nLista de funcionários ordenada em ordem alfabética");
            var funcionariosOrdenados = funcionarios.OrderBy(f => f.Nome);
            foreach(var funcionario in funcionariosOrdenados)
            {
                Console.WriteLine($"{funcionario.Nome}\tR${funcionario.Salario}");
            }

            //Lista depois da promoção
            Console.WriteLine("\nLista de Sêniors\n");
            var promocao = funcionarios.FindAll(f => f.Salario >= 4000.00);
            foreach (var funcionario in promocao)
            {
                Console.WriteLine($"{funcionario.Nome}\tR${funcionario.Salario}");
            }


            static void ExibirInformacoes(List<Funcionario> funcionarios)
            {

                double soma = 0;
                Console.WriteLine($"Nome\tSalário");
                foreach(var funcionario in funcionarios)
                {
                    Console.WriteLine($"{funcionario.Nome}\tR${funcionario.Salario}");
                    soma += funcionario.Salario;
                }
                
                double media = soma / funcionarios.Count;
                Console.WriteLine($"O total de colaboradores na empresa é de = {funcionarios.Count}");
                Console.WriteLine($"A média salarial da empresa é de = R${Math.Round(media, 2)}");
            }
        }
    }
}
