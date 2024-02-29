
/*

namespace Oficina;

public class Veiculo
{
    public Veiculo(string marca, string modelo, int ano, string placa)
    {
        Marca = marca;
        Modelo = modelo;
        Ano = ano;
        Placa = placa;
    }

    public string Marca { get; }
    public string Modelo { get; }
    public int Ano { get; }
    public string Placa { get; }
}

public class Cliente
{
    public Cliente(string nome, string contato)
    {
        Nome = nome;
        Contato = contato;
    }

    public string Nome { get; }

    public string Contato { get; }
}

public class Mecanico
{
    public Mecanico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }

    public string Nome { get; }
    public string Especialidade { get; }

}

public class Oficina
{
    private List<Veiculo> veiculosNaOficina;


    public Oficina()
    {
        veiculosNaOficina = new List<Veiculo>();
    }

    public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string dataAgendamento)
    {
        veiculosNaOficina.Add(veiculo);

        Console.WriteLine($"Serviço agendado para {veiculo.Placa} em {dataAgendamento} com o mecânico {mecanico.Nome}.");
    }

    public List<Veiculo> ListarVeiculos()
    {
        return veiculosNaOficina;
    }

    public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
    {
        if (veiculosNaOficina.Contains(veiculo))
        {
            Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo mecânico {mecanico.Nome}.");
            veiculosNaOficina.Remove(veiculo);
        }
        else
        {
            Console.WriteLine($"O veículo {veiculo.Placa} não está na oficina para realizar o serviço.");
        }
    }

}



//Program.cs
namespace Oficina;

class Program
{
    static void Main()
    {
        Veiculo meuCarro = new("Chevrolet", "Cruze", 2020, "ABC1234");
        Cliente cliente = new("Carlos", "(21) 987654321");
        Mecanico mecanico = new("Carlos", "987654321");
        Oficina oficina = new();


        oficina.AgendarServico(meuCarro, cliente, mecanico, "18-12-2023");
        oficina.RealizarServico(meuCarro, mecanico);
    }
}

*/