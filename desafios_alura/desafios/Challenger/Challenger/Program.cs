/*public interface IForma
{
    double CalcularArea();
    double CalcularPerimetro();
}

public class Circulo : IForma
{
    public double Raio { get; set; }

    public double CalcularArea()
    {
        return Math.PI * Math.Pow(Raio, 2);
    }

    public double CalcularPerimetro()
    {
       return 2 * Math.PI * Raio;
    }
}

public class Retangulo : IForma
{
    public double Comprimento { get; set; }
    public double Largura { get; set; }

    public double CalcularArea()
    {
        return Comprimento * Largura;
    }

    public double CalcularPerimetro()
    {
        return 2 * (Comprimento + Largura);
    }
}

*/
/*
public interface IPilotavel
{
    void Pilotar();
}

public interface IVoavel
{
    void Voar();
}

public class Veiculo : IPilotavel, IVoavel
{
    public void Pilotar()
    {
        Console.WriteLine("Pilotando");
    }

    public void Voar()
    {
        Console.WriteLine("Veiculo está voando");
    }
}

*/
/*
using System.Security.Cryptography.X509Certificates;

public interface IPagavel
{
    decimal CalcularPagamento();
}

public class Produto : IPagavel
{
    public string Nome { get; set; }
    public decimal PrecoUnitario { get; set; } 
    public int Quantidade { get; set; }

        public decimal CalcularPagamento()
        {
            return PrecoUnitario * Quantidade;
        }
}

public class Servico : IPagavel
{
    public string Nome { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int HorasTrabalhadas { get; set; }

    public decimal CalcularPagamento()
    {
        return PrecoUnitario * HorasTrabalhadas;
    }

}
*/

public interface INotificavel
{
    void EnviarNotificacao();
}

public class SMS : INotificavel
{
    public string NumeroTelefone { get; set; }
    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando SMS para {NumeroTelefone}: Notificação importante!");
    }
}

public class Email : INotificavel
{
    public string EnderecoEmail { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Enviando e-mail para {EnderecoEmail}: Notificação importante!");
    }
}   