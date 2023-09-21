// See https://aka.ms/new-console-template for more information
Console.WriteLine("Quel est votre nom?");

string line = Console.ReadLine();

Console.WriteLine("Bienvenue " + line + " a l'application!!");


Console.WriteLine("Entrez un temperature en Celsius");
double temperatureEnCelcius = Convert.ToDouble(Console.ReadLine());
double temperatureEnFahrenheit = temperatureEnCelcius * 9 / 5 + 32;

Console.WriteLine($"Votre temperature en fahrneheit est {temperatureEnFahrenheit}");
