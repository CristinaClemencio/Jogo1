public class Principe
{
    public string Nome {get; set;}
    public int Vida {get; set;}

    public int Dano {get; set;}
    public int Pontuacao {get; set;}
    public float Velocidade {get; set;}

    public Principe(string nome)
    {
        Nome = nome;
        Vida = 100;
        Pontuacao = 0;
        Dano = 20;
        Velocidade = 5f;
    }

    public void MostrarDados()
    {Console.WriteLine($"Nome:{Nome}");
     Console.WriteLine($"Vida:{Vida}");
    }

    public void Mover()
    {
        Console.WriteLine("O Principe moveu-se");
    
    }
      public void Saltar()
    {
        Console.WriteLine("O Principe saltou");
    

    }
      public void Atacar(Inimigo inimigo)
    {
        inimigo.ReceberDano(20);
    
        Console.WriteLine("O Principe atacou");
    
    }

    public void ReceberDano(int dano)
    {
        Console.WriteLine($"O príncipe recebeu {dano} pontos de dano");
        Console.WriteLine($"Vida restante: {Vida}");
    }

      public void RecolherMoeda()
    {
        Console.WriteLine("O Principe recolheu moeda");
    
    }

      public void PerderVida()
    {
        Console.WriteLine("O Principe perdeu vida");
    
    }


}