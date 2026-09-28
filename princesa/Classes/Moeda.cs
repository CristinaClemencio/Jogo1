public class Moeda

{
    public int Valor {get; set;}
    public Moeda()
    {
        Valor = 10;
    }
    public void Recolher()
    {
        Console.WriteLine("Moeda recolhida.");
    }
}