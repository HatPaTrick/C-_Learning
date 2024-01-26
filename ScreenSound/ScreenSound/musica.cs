using System.Security.Cryptography;
using System.Threading.Channels;

class Musica
{
    public string Nome { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => 
        $"A música {Nome} pertence à banda {Artista}";


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
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
