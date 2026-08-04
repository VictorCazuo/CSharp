bool nomeLimpo = true;
double salario = 2500.00;
bool temFiador = true;

if (nomeLimpo == true && (salario > 3000.00 || temFiador == true))
{
    Console.WriteLine("Empréstimo aprovado");
} else
{
    Console.WriteLine("Empréstimo negado");
}


//Não, pois verificarConexaoInternet é um método e os operadores lógicos só funcionam em espressões lógicas