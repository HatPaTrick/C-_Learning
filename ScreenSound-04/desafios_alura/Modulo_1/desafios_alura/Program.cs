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

/** 
public class Flamengo()
{
int a;
int b;
    public void AinFlamengo()
    {
            Console.WriteLine("Digite o primeiro numero: ");
                a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
                b = int.Parse(Console.ReadLine());
        try
        {
            Console.WriteLine($"Resultado   : {a/b}");
        }catch(Exception e){
            Console.WriteLine(e.Message);
        }
    }
}
*/     
   

class Program{
    public static void Main(string[] args){
            List<int> numeros = new List<int> {10, 20, 30, 40, 50, 60, 70, 80, 90, 100};

            try {
                int valor = numeros[10];
                Console.WriteLine(valor);
            }catch(ArgumentOutOfRangeException ex){
                Console.WriteLine($"Erro: {ex.Message}");
                
            }catch(Exception ex){
                Console.WriteLine($"Erro inexperado: {ex.Message}");
            }

    }
}

