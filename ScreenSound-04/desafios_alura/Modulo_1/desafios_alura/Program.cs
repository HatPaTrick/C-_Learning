List<string> palavras = new List<string> { "banana", "maçã", "abacaxi", "laranja", "uva" };

    var palavrasOrdenadas = palavras.OrderBy(p => p.Last()).ThenBy(p => p.Length).ToList();

    foreach(var palavra in palavrasOrdenadas)
    {
        System.Console.WriteLine(palavra);
    }