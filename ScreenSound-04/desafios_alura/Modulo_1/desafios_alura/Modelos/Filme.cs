
class Personagem
{
    public string name { get; set; } 
    public List<string>? aliases { get; set; }

    public void ExibirApelidosDosPersonagens()
    {
        System.Console.WriteLine($"Nome: {name}");
        System.Console.WriteLine($"Apelidos:");
        foreach(var apelido in aliases)
        {
            System.Console.WriteLine($" - {apelido}");
        }
    }
}