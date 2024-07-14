using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros
{
    public class LinqOrder
    {
        public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)// Exibe a lista de artistas ordenados
        {
            var artistasOrdernados = musicas.OrderBy(musica => musica.Artista)
            .Select(musica => musica.Artista)   // Seleciona apenas o nome das musicas
            .Distinct() // Retira os nomes duplicados
            .ToList(); // Transforma a lista em uma lista de objetos

            System.Console.WriteLine("Lista de Artistas Ordenados: "); 
            foreach(var artista in artistasOrdernados) // Exibe a lista de artistas ordenados
            {
                System.Console.WriteLine($" -> {artista}"); // Exibe o nome do artista
            }
        }


        public void FiltrarMusicasPorAno(List<Musica> musicas, int ano) // Filtra as musicas por ano
        {
            var musicasDoAno = musicas.Where(musicas => musicas.Ano == ano)// Filtra as musicas pelo ano
            .OrderBy(musicas => musicas.Nome)// Ordena a musica pelo nome
            .Select(musicas => musicas.Nome)// Seleciona apenas o nome das musicas
            .Distinct() // Retira os nomes duplicados
            .ToList(); // Transforma a lista em uma lista de objetos


            System.Console.WriteLine($"Lista de Musicas do Ano: {ano} ");
            foreach(var musica in musicasDoAno) // Exibe a lista de musicas do ano
            {
                System.Console.WriteLine($" -> {musica} ");
            }
        }
    }
}