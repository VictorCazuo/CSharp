int anterior = 0;
int atual = 1;
int proximo = anterior + atual;

Console.WriteLine(anterior);

while (atual < 1000)
{
    Console.WriteLine(proximo);


    proximo = atual + anterior;
    anterior = atual;
    atual = proximo;

    //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55,
    //a, at, p
}

//1) Peça ao usuário um número. Usando um for, imprima a tabuada desse número do 1 ao 10
Console.WriteLine("Digite um número e te darei a tabuada:");
int num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"{num} X {i} = {num * i}");
}
