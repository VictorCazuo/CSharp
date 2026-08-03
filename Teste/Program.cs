int iterador = 1;
int tabuada = 2;

do
{
    do
    {
        Console.WriteLine($"{tabuada} X {iterador} = {tabuada * iterador}");
        iterador++;
    } while (iterador <= 10);

    Console.WriteLine(" ");
    tabuada++;
    iterador = 1;

} while (tabuada <= 6);


