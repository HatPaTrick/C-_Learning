using HttpClient client = new HttpClient();
string result = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
System.Console.WriteLine(result);
try
{
    int a;
    int b;
    System.Console.WriteLine("Digite o Primeiro Numero: ");
    a = int.Parse(Console.ReadLine());
    System.Console.WriteLine("Digite o Segundo Numero: ");
    b = int.Parse(Console.ReadLine());

    if(a == 0 || b == 0)
    {
        System.Console.WriteLine("Divisão Impossivel");
        return;
    }
    else
    {
            int c = a / b;
            System.Console.WriteLine($"Divisão: {c}");
    }
}catch (Exception e)
{
    System.Console.WriteLine(e.Message);
}

static void Main(string[] args)
{
    
}