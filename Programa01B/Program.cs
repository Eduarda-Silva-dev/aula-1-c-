using Programa01B;
using System.Security.Cryptography;

Console.WriteLine("********** SISTEMA LOJA BIKE");
Console.WriteLine();

//instanciando objetos da classe
Bike bike = new Bike();

Console.WriteLine("Modelo Bike");
bike.Modelo = Console.ReadLine();

Console.WriteLine("Capaciadde da Bateria");
bike.Bateria = double.Parse(Console.ReadLine());

Console.WriteLine("Peso do Ciclista");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("quantidade estimada de recarga:");
bike.RecargaMes = int.Parse(Console.ReadLine());

//exibe na talo resutado

Console.WriteLine("\n -----RELATORIO DE DESEMPENHO DA BIKE----");
Console.WriteLine($"BIKE: {bike.Modelo.ToUpper()}");
Console.WriteLine($"AUTONOMIA ESTIMADA: {bike.CalcularAutonomia():F1}por carga");
Console.WriteLine($"CONSUMO MENSAL: {bike.CalcularConsumoMensal():F2} Km");
Console.WriteLine($"CONSUMO MENSAL: {bike.CalcularConsumoMensal():N2}");
Console.WriteLine($"A bike e economica: {bike.BikeEconomica}");