﻿namespace Alura.Filmes;
using Alura.Filmes;

public class Filme
{
    public Filme(string titulo, int duracao, List<string> elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        if (elenco == null)
        {
            Elenco = new List<string>();
        } else
        {
            Elenco = elenco;
        }


    }

    public string Titulo { get; }
    public int Duracao { get; }
    public List<string> Elenco { get; }

    public void AdicionarElenco(string ator)
    {
        if (Elenco.Contains(ator))
        {
            Console.WriteLine($"O {ator} já está incluído(a) no elenco.");
            return;
        }
        Elenco.Add(ator);
        var artista = new Artista(ator, 0); // Cria uma nova instância da classe Artista
        if (!artista.FilmesAtuados.Contains(this))
        {
            artista.AdicionarFilme(this);
        }

        Console.WriteLine($"{ator} adicionado/a com sucesso");
    }

    public void RemoverElenco(string ator)
    {
        Elenco.Remove(ator);
        Console.WriteLine($"{ator} removido/a com sucesso");
    }

    public void ListarElenco()
    {
        if (Elenco.Count == 0)
        {
            Console.WriteLine("Não tem pessoas no elenco.");
        }

        Console.WriteLine("Elenco: ");
        foreach (var ator in Elenco)
        {
            Console.WriteLine(ator);
        }
    }

}