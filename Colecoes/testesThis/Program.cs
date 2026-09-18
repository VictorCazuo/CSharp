using Indexadores;


//Estacionamento

Console.WriteLine("\nExercicio 1 -- Estacionamento");
Estacionamento e = new Estacionamento();

e[1] = "ABC-1234";

Console.WriteLine(e[1]);

//Cardapio

Console.WriteLine("\nExercicio 2 -- Cardárpio");
Cardapio c = new Cardapio();

Console.WriteLine(c["Refrigerante"]); 
Console.WriteLine(c["Batata"]);

//Cinema

Console.WriteLine("\nExercicio 3 -- Cinema");
Cinema ci = new Cinema();

ci[2, 1] = "Victor";

Console.WriteLine(ci[1, 1]);
Console.WriteLine(ci[2,1]);
Console.WriteLine(ci[4,1]);
