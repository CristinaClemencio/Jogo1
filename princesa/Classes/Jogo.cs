public class Jogo
{
    public Principe Jogador {get; set;}
    public Inimigo Inimigo {get; set;}

    public Jogo()
    {
        Jogador = new Principe("Artur");
        Inimigo = new Inimigo("Dragon");
    }



    public void Iniciar()
    {
        Console.WriteLine("Jogo iniciado!");
    }
    public void Terminar()
    {
        Console.WriteLine("Jogo terminado!");
    }


}