using Alura.Filmes;

Filme filme = new Filme("Um sonho da liberdade", 142, new List<string>() {"Tim Robbins", "Morgan Freeman"});
Filme filme2 = new("O poderoso chefão", 175, new List<string>() { "Marlon Brando", "Al Pacino", "Talia Shire" });
Filme filme3 = new("Batman - O Cavaleiro das Trevas", 152, new List<string>() { "Christian Bale", "Heath Ledger", "Maggie Gyleenhaal" });
Filme filme4 = new("Senhor dos Anéis - O Retorno do Rei", 201, new List<string>() { "Elijah Wood", "Ian McKellen", "Viggo Mortensen" });
Filme filme5 = new("Green Book - O Guia", 130, new List<string>() { "Viggo Mortensen", "Mahershala Ali" });


List<Filme> meusFilmesFavoritos = new List<Filme>() { filme, filme2, filme3, filme4, filme5 };

foreach (Filme f in meusFilmesFavoritos)
{
    Console.WriteLine($"Filme: {f.Titulo}");
    Console.WriteLine($"Duração: {f.Duracao}");
    f.ListarElenco();
    Console.WriteLine();
}
