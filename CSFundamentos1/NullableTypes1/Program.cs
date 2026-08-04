Console.WriteLine("Tipos Nullable");
//Quando se usa o nullable, ele aceita os valroes do tipo, mais o null

//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;



//Para simplificar a declaração podemos usar o operador ?

int? i = null;
double? d = null;
float? F = null;
bool? B = null;

Console.WriteLine(i);
Console.WriteLine(d);
Console.WriteLine(F);
Console.WriteLine(B);

int? a = null;

int b = a ?? 10; // ?? = se o a for null, eu aplico o 10, se não eu aplico o valor de a
Console.WriteLine(b);


int? x = 4;
int? y = 3;
int? z = x * y;

//Propiredades de somente leitura dos nullable = HasValue e Value
//HasValue = true se tiver um valor e false se não tiver valor(null)
//Value = Exibe o valor

int? itemA = null;

if (itemA.HasValue)
{
    Console.WriteLine($"Item A = {itemA.Value}");
} else
{
    Console.WriteLine("Item A não possui um valor");
}