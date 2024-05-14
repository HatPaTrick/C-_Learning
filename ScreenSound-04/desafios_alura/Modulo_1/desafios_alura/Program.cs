/** using System;
 * 
using (HttpClient client = new HttpClient()){
    try{
        string response = await client.GetStringAsync($"https://www.cheapshark.com/api/1.0/deals");
        System.Console.WriteLine(response);
    }
    catch(Exception e){
        System.Console.WriteLine(e.Message);
    }
}*/

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            double a;
            double b;
            Console.Write($"Digite um Numero: ");
            a = double.Parse(Console.ReadLine());
            Console.Write($"Digite outro Numero: ");
            b = double.Parse(Console.ReadLine());

            double resultado = a / b;
            Console.WriteLine($"{resultado}");
            
        }catch(DivideByZeroException e)
        {
            Console.WriteLine($"Texto: {e.Message}");
            
        }
    }
}
   
/**class Program{
    public static void Main(string[] args){
            List<int> numeros = new List<int> {10, 20, 30, 40, 50, 60, 70, 80, 90};

            try {
                foreach(int numero in numeros){
                Console.WriteLine(numero);
            }
                foreach(int numero in numeros){
                    if(numero < 0){
                        throw new ArgumentOutOfRangeException("O numero não pode ser negativo");
                    }
                    Console.WriteLine(numero);
                }
            }catch(ArgumentOutOfRangeException ex){
                Console.WriteLine($"Erro: {ex.Message}");
                
            }catch(Exception ex){
                Console.WriteLine($"Erro inexperado: {ex.Message}");
            }
    }
}
 */


/**
class Pessoa
{
    public string Nome { get; set; }

    public void ExibirNome()
    {
        Console.WriteLine($"Nome: {Nome}");
        
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa = new Pessoa();
        
        try
        {

            if(pessoa == null){
                throw new NullReferenceException("Objeto nulo");
            } else{
                pessoa.Nome = "João";
                pessoa.ExibirNome();
            } // Chamando o método em um objeto nulo
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }

        Console.ReadLine();
    }
}

 */