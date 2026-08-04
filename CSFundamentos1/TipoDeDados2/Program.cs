Console.WriteLine("Atribuindo valores a double, float e decimal");
Console.WriteLine();
double n1 = 1.234; //ou double n1 = 1.234d; lembrando que se não colocar o d, o compilador entende que é double
float n2 = 1.234f;
decimal n3 = 1.234m;

decimal n4;
n4 = 1.234m;

Console.WriteLine(n1);
Console.WriteLine(n2);
Console.WriteLine(n3);
Console.WriteLine(n4);
Console.ReadLine();


Console.WriteLine("Comparando a precisão dos tipos double, float e decimal");

float x = 1f / 3f;
double y = 1d / 3d;
decimal z = 1m / 3m;

Console.WriteLine(x);
Console.WriteLine(y);
Console.WriteLine(z);