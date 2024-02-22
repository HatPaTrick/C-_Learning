namespace Alura.Filmes;

public class Artista
{
    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }

    public string Nome { get; }
    public int Idade { get; }
    public List<Filme> FilmesAtuados { get; set; }
    public int QuantidadeDeFilmes => FilmesAtuados.Count;


    public void AdicionarFilme(Filme filme) 
    {
        FilmesAtuados.Add(filme);
        if (!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
    }

    public void MostrarFilmesAtuados()
    {
        if(QuantidadeDeFilmes == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base de dados para {this.Nome}");
            return;
        }

        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine("Filmes: ");
            Console.WriteLine(filme);
        }
    }

}