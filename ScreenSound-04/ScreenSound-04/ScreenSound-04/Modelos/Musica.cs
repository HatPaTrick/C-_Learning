using System.Text.Json.Serialization;
namespace ScreenSound_04.Modelos;
   
    public class Musica
    {
        [JsonPropertyName("song")]
        public string? Nome { get; set; }
        [JsonPropertyName("artist")]
        public string? Artista { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        System.Console.WriteLine($"Artista: {Artista}\n Nome: {Nome}\n Duracao: {Duracao/1000}s\n Gênero: {Genero}\n");
    }
}
