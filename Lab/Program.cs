using RestSharp;
using System.Text.Json;
using System.Net;
RestClient pokeClient = new RestClient("https://pokeapi.co/api/v2/");
RestRequest request = new("pokemon/sceptile");
RestResponse response = pokeClient.GetAsync(request).Result;


if (response.StatusCode == HttpStatusCode.OK)
{
Pokemon p = JsonSerializer.Deserialize<Pokemon>(response.Content);
Console.WriteLine(p.name);
Console.WriteLine(p.weight); 
Console.WriteLine(p.height);
}

else
{
    Console.WriteLine("WHAT THE FUCK?!?!?!?!");
}



//Console.WriteLine(response.Content);

Console.ReadLine();

