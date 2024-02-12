class Banda
{
    private List<Album> albuns = new List<Album>();
    public string Nome { get; set; }
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void Exibirdiscografia()
    {
        Console.WriteLine($"Discografia da Banda {Nome}");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal})");
        }
    }
}