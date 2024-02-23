
class Pet
{
    public Pet(string nome, int idade, string especie)
    {
        Nome = nome;
        Idade = idade;
        Especie = especie;
    }

    public string Nome { get; }
    public int Idade { get; }
    public string Especie { get; }
}

class Dono
{
    public Dono(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }

    public string Nome { get; }
    public string Contato { get; }


}

class Consulta
{
    public Pet Animal { get; }
    public Dono Dono { get; }
}

class Medico
{
    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public string Nome { get; }
    public string Especialidade { get; }

}