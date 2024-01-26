using System.Security.Cryptography;
using System.Threading.Channels;

class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel { get; set; }


    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel)


        {
            Console.WriteLine("Música disponível no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Premium.");
        }

    }



}
