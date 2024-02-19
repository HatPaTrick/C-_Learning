using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Podcast
{
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    public int TotalEpisodios;

  
    public void ExibirEpisodios()
    {
        Console.WriteLine();
    }
}