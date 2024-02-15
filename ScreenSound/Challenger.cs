using System.ComponentModel;

class Titular
{
    public Titular(string nome, string cpf, string endereco)
    {
        Nome = nome;
        Cpf = cpf;
        Endereco = endereco;

        Titular titular = new Titular("George Harrison", "000.000.000-00", "Rua dos Besouros, Liverpool");
        Conta c = new Conta(titular, 1, 2234, 100000);


        Console.WriteLine(c.Informacoes);
    }

    public string Nome { get; set; }
    public string Cpf { get; set; }
    public string Endereco { get; set; }
}

class Conta
{
    public Titular Titular { get; set; }
    public int Agencia { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; }
    public double Limite { get; set; }

    public string Informacoes => $"Conta nº {this.NumeroDaConta}, Agência {this.Agencia}, Titular: {this.Titular.Nome} - Saldo: {this.Saldo}";
    
    public Conta (Titular titular, int agencia, int numeroDaConta, double limite)
    {
        this.Titular = titular;
        this.Agencia = agencia;
        this.NumeroDaConta = numeroDaConta;
        this.Limite = limite;
        this.Saldo = 0;
    }
 }

