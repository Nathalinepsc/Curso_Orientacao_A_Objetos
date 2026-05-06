using System;

class Pessoa // Toda classe inicia com letra maiuscula e o nome deve ser substantivo
{

    // Metodo 01
    public void Apresentar()
    {
        Console.WriteLine("Olá, seja bem vindo!");
    }

    // Metodo 02
    public void Apresentar(string nome)
    {
        Console.WriteLine($"Olá, seja bem vindo {nome}!");
    }

    // Metodo 03
    public void Apresentar(string nome, int idade)
    {
        Console.WriteLine($"Olá, seja bem vindo {nome}! Sua idade é {idade} anos.");
    }

}