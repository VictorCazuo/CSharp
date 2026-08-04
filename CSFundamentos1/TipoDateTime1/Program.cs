Console.WriteLine("DateTime em C#");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

DateTime dataCriada = new DateTime(2026, 03, 07, 12, 00, 00);
Console.WriteLine(dataCriada);

DateTime meuAniversario = new DateTime(2026, 03, 07, 00, 00, 00);
Console.WriteLine(meuAniversario);

//Consultando valores
Console.WriteLine(meuAniversario.Year);
Console.WriteLine(meuAniversario.Month);
Console.WriteLine(meuAniversario.Day);
Console.WriteLine(meuAniversario.Hour);
Console.WriteLine(meuAniversario.Minute);
Console.WriteLine(meuAniversario.Second);
Console.WriteLine(meuAniversario.Millisecond);

//adicionando valores

Console.WriteLine(meuAniversario.AddDays(07));
Console.WriteLine(meuAniversario.AddHours(07));
Console.WriteLine(meuAniversario.AddMinutes(07));
Console.WriteLine(meuAniversario.AddSeconds(07));
Console.WriteLine(meuAniversario.AddYears(07));

//obter o dia da semana

Console.WriteLine(meuAniversario.DayOfWeek);
Console.WriteLine(meuAniversario.DayOfYear);


//Data no formato longo e abreviado
Console.WriteLine(meuAniversario.ToLongDateString());
Console.WriteLine(meuAniversario.ToShortDateString());

//Hora no formato longo e abreviado
Console.WriteLine(meuAniversario.ToLongTimeString());
Console.WriteLine(meuAniversario.ToShortTimeString());