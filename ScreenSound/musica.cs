using System.Security.Cryptography;
using System.Threading.Channels;

class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    //Flamengo
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public Genero Genero { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Descrição: {DescricaoResumida}");
        if (Disponivel)


        {
            Console.WriteLine("Música disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Premium.");
        }

    }
}
