class Jogador
{
    Random random = new Random();
    public string nome;
    public string nickname;
    public int pontos = 0;

    public void Jogar()
    {
        pontos = random.Next(1,101);
    }
}