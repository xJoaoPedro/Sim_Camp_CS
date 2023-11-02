class Equipe
{
    public string nomeEquipe;
    public Jogador j1;
    public Jogador j2;
    public Jogador j3;
    public Jogador j4;
    public Jogador j5;



    public int PontosTotal()
    {
        return j1.pontos + j2.pontos + j3.pontos + j4.pontos + j5.pontos;
    }
    
    public void Adicionarjogador(Jogador jogadorNovo)
    {
        if (j1 == null)
        {
            j1 = jogadorNovo;
            if (j1.nome.Contains(" "))
            {
                string[] nomeSplit = j1.nome.Split(" ");
                Console.WriteLine($"Jogador {nomeSplit[0]} '{j1.nickname}' {nomeSplit[1]} adicionado à posição 1.");
            }
            else
            {
                Console.WriteLine($"Jogador {j1.nome} '{j1.nickname}' adicionado à posição 1.");
            }
        }
        else if (j2 == null)
        {
            j2 = jogadorNovo;
            if (j2.nome.Contains(" "))
            {
                string[] nomeSplit = j2.nome.Split(" ");
                Console.WriteLine($"Jogador {nomeSplit[0]} '{j2.nickname}' {nomeSplit[1]} adicionado à posição 2.");
            }
            else
            {
                Console.WriteLine($"Jogador {j2.nome} '{j2.nickname}' adicionado à posição 2.");
            }
        }
        else if (j3 == null)
        {
            j3 = jogadorNovo;
            if (j3.nome.Contains(" "))
            {
                string[] nomeSplit = j3.nome.Split(" ");
                Console.WriteLine($"Jogador {nomeSplit[0]} '{j3.nickname}' {nomeSplit[1]} adicionado à posição 3.");
            }
            else
            {
                Console.WriteLine($"Jogador {j3.nome} '{j3.nickname}' adicionado à posição 3.");
            }
        }
        else if (j4 == null)
        {
            j4 = jogadorNovo;
            if (j4.nome.Contains(" "))
            {
                string[] nomeSplit = j4.nome.Split(" ");
                Console.WriteLine($"Jogador {nomeSplit[0]} '{j4.nickname}' {nomeSplit[1]} adicionado à posição 4.");
            }
            else
            {
                Console.WriteLine($"Jogador {j4.nome} '{j4.nickname}' adicionado à posição 4.");
            }
        }
        else if (j5 == null)
        {
            j5 = jogadorNovo;
            if (j5.nome.Contains(" "))
            {
                string[] nomeSplit = j5.nome.Split(" ");
                Console.WriteLine($"Jogador {nomeSplit[0]} '{j5.nickname}' {nomeSplit[1]} adicionado à posição 5.");
            }
            else
            {
                Console.WriteLine($"Jogador {j5.nome} '{j5.nickname}' adicionado à posição 5.");
            }
        }
        else
        {
            Console.Write($"A equipe {nomeEquipe} já está cheia, pressione enter para continuar. ");
        }
        Console.ReadKey();
    }
}