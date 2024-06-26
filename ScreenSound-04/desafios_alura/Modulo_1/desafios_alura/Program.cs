using HttpClient client = new();

string response = await client.GetStringAsync("https://www.anapioficeandfire.com/api/characters/16");
System.Console.WriteLine(response);