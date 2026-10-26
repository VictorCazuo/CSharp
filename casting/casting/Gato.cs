public class Animal
{
    public string Nome { get; set; } = string.Empty;

    public void Comer()
    {
        Console.WriteLine("Comendo...");
    }
}

public class Gato : Animal
{
    public void ArranharSofa()
    {
        Console.WriteLine("Arranhando sofá....");
    }
}

