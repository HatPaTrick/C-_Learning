﻿class Banda
{
    private List<Album> albuns = new List<Album>();
  

    public Banda(string nome)
    {
        Nome = nome;  
    }
    public string Nome { get; }
    public void AdicionarAlbum(Album album)
    {
        albuns.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da Banda {Nome}");
        foreach (var album in albuns)
        {
            Console.WriteLine($"Álbum: {album.Nome} - ({album.DuracaoTotal})");
        }
    }
}