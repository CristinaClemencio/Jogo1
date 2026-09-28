Principe jogador = new Principe("Artur");
Inimigo dragao = new Inimigo("Dragon");
Moeda moeda = new Moeda();
Castelo castelo = new Castelo();

Console.WriteLine("Objetos criados com sucesso!");


jogador.Nome = "Artur";
dragao.Nome = "Dragon";
jogador.Atacar(dragao);

Console.WriteLine("Jogador: " + jogador.Nome);
Console.WriteLine("Inimigo: " + dragao.Nome);

jogador.MostrarDados();
dragao.MostrarDados();

dragao.Atacar();
jogador.ReceberDano(dragao.Dano);

