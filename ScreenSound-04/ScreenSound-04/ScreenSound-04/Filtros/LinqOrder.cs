using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    public class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
        {
            var artistasOrdernados = musicas.OrderBy(musica => musica.Artista).Select
            (musica => musica.Artista).Distinct().ToList();
            System.Console.WriteLine("Lista de Artistas Ordenados: ");
            foreach(var artista in artistasOrdernados)
            {
                System.Console.WriteLine($" -> {artista}");
            }
        }
    }
}