Console.WriteLine("Decremento e Incremento");

int x = 0;
Console.WriteLine($"x = {x}");

//Pós-Incremento -> resolve primeiro e depois acrescenta
int resultado1 = x++ + 10;
Console.WriteLine($"Pós-incremento => {resultado1} ");
Console.WriteLine($"valor de x => {x}\n");

//Pré-Incremento -> acrescenta primeiro e depois resolve
int y = 0;
int resultado2 = ++y + 10;
Console.WriteLine($"Pré-incremento => {resultado2}");
Console.WriteLine($"Valor de y => {y}");

//decremento a mesma coisa, só que subtrai

