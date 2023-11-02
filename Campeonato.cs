class Campeonato
{
    public string nomeCampeonato;
    public Equipe equipe1 = new Equipe();
    public Equipe equipe2 = new Equipe();

    public void IniciarPartida(Equipe e1, Equipe e2)
    {
        if (e1.j1 == null || e1.j2 == null || e1.j3 == null || e1.j4 == null || e1.j5 == null || e2.j1 == null || e2.j2 == null || e2.j3 == null || e2.j4 == null || e2.j5 == null)
        {
            Console.Clear();
            Console.Write("É necessário estar com as equipes completas para inicar o campeonato. ");
            Console.ReadKey();
        }
        else
        {
            e1.j1.Jogar();
            e1.j2.Jogar();
            e1.j3.Jogar();
            e1.j4.Jogar();
            e1.j5.Jogar();
            e2.j1.Jogar();
            e2.j2.Jogar();
            e2.j3.Jogar();
            e2.j4.Jogar();
            e2.j5.Jogar();

            Classificacao();
        }
    }

    public void Classificacao()
    {
        Console.Clear();
        Console.WriteLine($"Pontuação das equipes: \n {equipe1.nomeEquipe} - {equipe1.PontosTotal()} pontos \n {equipe2.nomeEquipe} - {equipe2.PontosTotal()} pontos.");

        if (equipe1.PontosTotal() > equipe2.PontosTotal())
        {
            Console.WriteLine($"\nCom {equipe1.PontosTotal()} pontos, a equipe {equipe1.nomeEquipe} venceu o campenato {nomeCampeonato}!");
        }
        else
        {
            Console.WriteLine($"\nCom {equipe2.PontosTotal()} pontos, a equipe {equipe2.nomeEquipe} venceu o campenato {nomeCampeonato}!");
        }
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine($"Obrigado por simular o campeonato {nomeCampeonato} conosco \naté a próxima.");
        System.Environment.Exit(0);
    }
}