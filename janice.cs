using System.Text;

namespace JogoRPG
{
        class Program
    {
        static Random sorte = new Random();

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Um objeto que ainda não existe vale "null" (nada).
            Personagem heroi = null;

            bool aSair = false;

            while (aSair == false)
            {
                MostrarMenu();
                string escolha = Console.ReadLine();

                switch (escolha)
                {
                    // ---------------------------------------------
                    case "1": // CRIAR HERÓI
                        string nome = LerTexto("\nQual é o nome do teu herói? ");

                        if (string.IsNullOrWhiteSpace(nome))
                        {
                            nome = "Herói Sem Nome";
                        }

                        // "new" cria o objeto a partir do molde (a classe).
                        heroi = CriarHeroi(nome);

                        Console.WriteLine("\nBem-vindo à aventura, " + heroi.Nome + "!");
                        MostrarFicha(heroi);
                        break;

                    // ---------------------------------------------
                    case "2": // VER FICHA
                        if (heroi == null)
                        {
                            Console.WriteLine("\nAinda não criaste nenhum herói. Escolhe a opção 1.");
                        }
                        else
                        {
                            MostrarFicha(heroi);
                        }
                        break;

                    // ---------------------------------------------
                    case "3": // BATALHAR
                        if (heroi == null)
                        {
                            Console.WriteLine("\nPrimeiro cria um herói (opção 1).");
                        }
                        else if (heroi.EstaVivo() == false)
                        {
                            Console.WriteLine("\nEstás sem vida. Descansa primeiro (opção 4).");
                        }
                        else
                        {
                            Personagem monstro = CriarMonstro(heroi.Nivel);

                            Batalhar(heroi, monstro);

                            if (heroi.EstaVivo())
                            {
                                int xpGanho = monstro.Nivel * 40;
                                int niveis = heroi.GanharXp(xpGanho);

                                Console.WriteLine("Ganhaste " + xpGanho + " pontos de experiência.");

                                if (niveis > 0)
                                {
                                    Console.WriteLine(">>> SUBISTE AO NÍVEL " + heroi.Nivel + "! Vida e estatísticas recuperadas.");
                                }
                            }
                            else
                            {
                                Console.WriteLine(heroi.Nome + " caiu em combate... Descansa para recuperar.");
                            }
                        }
                        break;

                    // ---------------------------------------------
                    case "4": // DESCANSAR
                        if (heroi == null)
                        {
                            Console.WriteLine("\nPrimeiro cria um herói (opção 1).");
                        }
                        else
                        {
                            heroi.CurarTudo();
                            Console.WriteLine("\n" + heroi.Nome + " descansou. Vida: " + heroi.Vida + "/" + heroi.VidaMaxima);
                        }
                        break;

                    // ---------------------------------------------
                    case "5": // SAIR
                        aSair = true;
                        Console.WriteLine("\nAté à próxima aventura!");
                        break;

                    default:
                        Console.WriteLine("\nOpção inválida. Escreve um número de 1 a 5.");
                        break;
                }

                if (aSair == false)
                {
                    Pausa();
                }
            }
        }
    }
}


