using System;
using System.Collections.Generic;
namespace Ead
{
    
public class Pokemon
{
    public string Nome { get; set; }
    public double Peso { get; set; }
    public double Altura { get; set; }
    public List<string> Tipos { get; set; }
    public List<Ataque> Ataques { get; set; }

    public Pokemon(string nome, double peso, double altura)
    {
        Nome = nome;
        Peso = peso;
        Altura = altura;
        Tipos = new List<string>();
        Ataques = new List<Ataque>();
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Olá! Eu sou o {Nome}!");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Altura: {Altura} m");

        Console.WriteLine("Tipos:");
        foreach (var tipo in Tipos)
        {
            Console.WriteLine($" - {tipo}");
        }

        Console.WriteLine("Ataques:");
        foreach (var ataque in Ataques)
        {
            Console.WriteLine($" - {ataque.Nome} ({ataque.Tipo})");
        }
    }
}
}
