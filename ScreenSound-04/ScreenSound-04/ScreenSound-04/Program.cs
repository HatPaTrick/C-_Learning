using System.Text.Json;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string result = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        System.Console.WriteLine();
        var musicas = JsonSerializer.Deserialize<List<Musica>>(result)!;
        musicas[0].ExibirDetalhesDaMusica();
    }catch(Exception e)
    {
        System.Console.WriteLine("Error: " + e.Message);
    }
}