namespace Program;

/*abstract class FormaGeometrica
{
    public abstract double CalcularArea();
    public abstract double CalcularPerimetro();
}




class Trigangulo : FormaGeometrica
{
    public double A { get; set; }
    public double B { get; set; }
    public double C { get; set; }

    public override double CalcularArea()
    {
        return 0.5 * A * C;
    }

    public override double CalcularPerimetro()
    {
        return A + B + C + Math.Sqrt((A - B) * (A - B) + (B - C) * (B - C));
    }
}


class Quadrado : FormaGeometrica
{
   public double Lado { get; set; }

    public override double CalcularArea()
    {
        return Lado * Lado;
    }

    public override double CalcularPerimetro()
    {
        return 4 * Lado;
    }
}

class Circulo : FormaGeometrica
{
    public double R { get; set; }

    public override double CalcularArea()
    {
        return Math.PI * R * R;
    }

    public override double CalcularPerimetro()
    {
        return 2 * Math.PI * R;
    }
}



class Funcionarios
{
    public string Nome { get; set; }
    public string Funcao { get; set; }
    public double Salario { get; set; }
}

class Gerente : Funcionarios
{
    public string Setor { get; set; }
}

class Programador : Funcionarios
{
    public string LinguagemDeProgramacao { get; set; } // C#, C++, Jav
    public string Framework { get; set; }
}

class Analista : Funcionarios
{
    public string AreaDeAtuacao { get; set; }
}

*/



class ContaBancaria
{
    protected double Saldo { get; set; }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
    }
    
    public virtual void Sacar (double valor)
    {
        Saldo -= valor;
    }

    public virtual double ConsultarSaldo()
    {
        return Saldo;
    }
}

class ContaCorrente : ContaBancaria
{
    private double TaxaManutencao { get; set; }

    public override void Sacar(double valor)
    {
        base.Sacar(valor + TaxaManutencao);
    }
}

class ContaPoupanca : ContaBancaria
{
    private double TaxaJuros { get; set; }

    public override double ConsultarSaldo()
    {
        return base.ConsultarSaldo() * (1 + TaxaJuros);
    }
}