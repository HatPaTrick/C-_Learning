using ScreenSound_04.Modelos;
namespace ScreenSound_04.Filtros;

    public class LinqFilter
    {
        public static void FiltrarTodosOsGeneros(List<Musica> musicas)
        {
            var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
            foreach(var genero in todosOsGenerosMusicais)
            {
                System.Console.WriteLine($" -> {genero}");
            }
        }

        public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
        {
            var musicasFiltradas = musicas.Where(musica => musica.Genero!.Contains(genero));
            var artistasPorGeneroMusicas = musicasFiltradas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista).Distinct().ToList();
            System.Console.WriteLine($"Lista de Artistas do Gênero: {genero} ");
            foreach(var artista in artistasPorGeneroMusicas)
            {
                System.Console.WriteLine($" -> {artista} ");
            }
        }


    }