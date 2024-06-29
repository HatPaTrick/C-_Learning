using System.Text.Json;
using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;

using (HttpClient client = new HttpClient())
{
    try
    {
        string result = await client.
        GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(result)!;
        //LinqFilter.FiltrarTodosOsGeneros(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
    }catch(Exception e)
    {
        System.Console.WriteLine("Error: " + e.Message);
    }
}