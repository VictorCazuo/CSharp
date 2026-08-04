Console.WriteLine("Identificadores em C#");

//Identificadores válidos

string nome;
string nomeCompleto;
int idade;
int _valor1;
int idade1;

//Identificadores inválidos

//int 5idade;
//int $valor;
//int valor#total;
//string nome completo;


//Nome para variáveis = Camel Case

string nomeCompletoP;
string nome_Completo;

//constantes: maiuscula
double PI = 3.14;
string PREFIXO = "11";
string PREFIXO_SP = "11";


//Nome para classes e métodos = Pascal Case
class ImprimindoTexto
{
    public void ImprimirNome()
    {
        Console.WriteLine("Olá, meu nome é victor");
    }
}

