// See https://aka.ms/new-console-template for more information
using IISHelper;

Console.WriteLine("Hello, World!");

var client = new Client("95100018", "Agireh30");
var res = await client.GetPersonalCv();