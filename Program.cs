    Menu m1 = new Menu();
Jogador[] todosJogadores = new Jogador[10];
Campeonato camp1 = new Campeonato();

Console.Clear();
Console.Write("Bem-vindo ao simulador de campeonato de CS\n Qual o nome do seu campeonato? ");
camp1.nomeCampeonato = Console.ReadLine();
do
{
    m1.ImprimeMenu();
    m1.lerResposta(todosJogadores, camp1);
} while (true);