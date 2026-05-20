using System;

class Pessoa
{
    // Construtor
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa foi chamado.");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine($"Olá, {nome}! Bem-vindo.");
    }
}