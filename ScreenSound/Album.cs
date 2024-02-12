class Album
{
    private List<Musica> musicaList = new List<Musica>();

    public Album(string nome)
    {
        Nome = nome;
    }

    public string Nome { get; }
    public int DuracaoTotal => musicaList.Sum(m => m.Duracao);

    public void AdicionarMusica(Musica musica)
    {
        musicaList.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de musicas do álbum {Nome}: \n");
        foreach (var musica in musicaList)
        {
            Console.WriteLine($"Música: {musica.Nome}");

        }
        Console.WriteLine($"Para ouvir este álbum inteiro, você precisa de {DuracaoTotal}");
    }
} 