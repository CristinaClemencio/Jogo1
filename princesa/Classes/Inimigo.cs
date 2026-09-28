public class Inimigo
{
    public string Nome {get; set;}
    public int Vida {get; set;}
    public int Dano {get; set;}
    public float Velocidade {get; set;}

    public Inimigo(string nome)
    {
        Nome = nome;
        Vida = 100;
        Dano = 20;
        Velocidade = 5f;
    }

    public void Atacar()
    {
        Console.WriteLine("O inimigo atacou.");
    }
    public void Mover()
    {
        Console.WriteLine("O inimigo moveu-se.");
    }
    public void ReceberDano(int dano)
    {
        Vida -= dano;
        Console.WriteLine($"{Nome} recebeu {Dano} pontos de dano");
        Console.WriteLine($"Vida restante: {Vida}");
        Console.WriteLine("{O inimigo perdeu energia.");
    } 

    public void MostrarDados()
    {
        Console.WriteLine($"Nome:{Nome}");
         Console.WriteLine($"Vida:{Vida}");
    }
}
