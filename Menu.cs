class Menu
{
    public int opcao = 0;
    public int numJogadores = 0;
    public int numEquipes = 0;
    public void ImprimeMenu()
    {
        try
        {
            Console.Clear();
            Console.Write("+");
            for (int i = 0; i <= 34; i++)
            {
                Console.Write("-");
                if (i == 11)
                {
                    Console.Write("Bem-vindo !");
                    i = 23;
                }
            }
            Console.Write("+\n");
            for (int lines = 0; lines <= 9; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 33; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|\n");
            }
            Console.Write("+");
            for (int i = 0; i <= 33; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            Console.SetCursorPosition(2, 2);
            Console.WriteLine("Simule o seu campeonato de CS!"); // mais uma partida do q campeonato
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1 - Adicione um jogador");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("2 - Adicione uma equipe");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("3 - Atribuir jogador a uma equipe");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("4 - Iniciar campeonato");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("5 - Sair");
            Console.SetCursorPosition(2, 10);
            Console.Write("Opção desejada: ");
        }
        catch (System.ArgumentOutOfRangeException)
        {
            Console.Clear();
            Console.WriteLine("Por favor, aumente o console e pressione enter para poder continuar com a aplicação.");
        }

    }

    public void lerResposta(Jogador[] todosJogadores, Campeonato camp1, Menu m1)
    {
        try
        {
            opcao = Convert.ToInt32(Console.ReadLine());
        }
        catch (System.FormatException)
        {
            Console.Clear();
            opcao = 0;
        }

        switch (opcao)
        {

            case 1:
                {
                    Console.Clear();
                    if (numJogadores == 10)
                    {
                        Console.Write("Numero máximo de jogadores adicionados, atribua-os às equipes. ");
                        Console.ReadKey();
                        break;
                    }
                    todosJogadores[numJogadores] = new Jogador();
                    Console.WriteLine("Digite o nome do jogador:");
                    todosJogadores[numJogadores].nome = Console.ReadLine();
                    Console.WriteLine("\nDigite o nickname do jogador:");
                    todosJogadores[numJogadores].nickname = Console.ReadLine();
                    numJogadores++;
                    Console.Write("\nJogador adicionado! Pressione qualquer tecla para voltar ao menu. ");
                    Console.ReadKey();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    if (numEquipes == 0)
                    {
                        Console.WriteLine("Digite o nome da primeira equipe:");
                        camp1.equipe1.nomeEquipe = Console.ReadLine();
                        Console.Write("\nEquipe adicionada! Pressione qualquer tecla para voltar ao menu. ");
                        Console.ReadKey();
                        numEquipes++;
                        break;
                    }
                    else if (numEquipes == 1)
                    {
                        Console.WriteLine("Digite o nome da segunda equipe:");
                        camp1.equipe2.nomeEquipe = Console.ReadLine();
                        Console.Write("\nEquipe adicionada! Pressione qualquer tecla para voltar ao menu. ");
                        Console.ReadKey();
                        numEquipes++;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Numero máximo de equipes atingido, atribua jogadores às equipes existentes. ");
                        Console.ReadKey();
                        break;
                    }
                }
            case 3:
                {
                    Console.Clear();
                    int posicao = 0;
                    int equipeSelecionada = 0;
                    if (camp1.equipe1.nomeEquipe == null || camp1.equipe2.nomeEquipe == null)
                    {
                        Console.Write("É preciso criar as 2 equipes participantes antes de atribuir os jogadores. ");
                        Console.ReadKey();
                        break;
                    }

                    if (numJogadores != 10)
                    {
                        Console.Write("É necessário cadastrar os 10 jogadores para continuar. ");
                        Console.ReadKey();
                        break;
                    }
                    Console.WriteLine("Escolha o jogador que quer atribuir: ");
                    foreach (Jogador i in todosJogadores)
                    {
                        if (i == null)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine($" {posicao + 1} - {todosJogadores[posicao].nickname}");
                            posicao++;
                        }
                    }
                    Console.Write("Opção: ");
                    try
                    {
                        posicao = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (System.FormatException)
                    {
                        Console.Clear();
                        Console.WriteLine("Erro. favor usar somente números na navegação do menu.");
                        Console.ReadKey();
                        opcao = 0;
                    }
                    while (posicao < 1 || posicao > 10)
                    {
                        Console.Write("Jogador indisponível, escolha entre 1-10: ");
                        posicao = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("\nAgora escolha a equipe a qual quer atribuir: ");
                    Console.WriteLine($" 1 - {camp1.equipe1.nomeEquipe}\n 2 - {camp1.equipe2.nomeEquipe}");
                    Console.Write("Opção: ");
                    equipeSelecionada = Convert.ToInt32(Console.ReadLine());
                    while (equipeSelecionada < 1 || equipeSelecionada > 2)
                    {
                        Console.Write("Equipe indisponível, escolha 1 ou 2: ");
                        equipeSelecionada = Convert.ToInt32(Console.ReadLine());
                    }

                    if (equipeSelecionada == 1)
                    {
                        camp1.equipe1.Adicionarjogador(todosJogadores[posicao - 1]);
                    }
                    else
                    {
                        camp1.equipe2.Adicionarjogador(todosJogadores[posicao - 1]);
                    }
                    break;
                }
            case 4:
                {
                    camp1.IniciarPartida(camp1.equipe1, camp1.equipe2);
                    break;
                }
            case 5:
                {
                    Console.Clear();
                    Console.WriteLine("Até a próxima!");
                    System.Environment.Exit(0);
                    break;
                }
            default: break;
        }
    }
}