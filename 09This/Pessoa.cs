using System;

class Pessoa
{
    
    // Atributo
    private string nome = "Maria";

    // Construtor
    public Pessoa(string nome)
    {
       Console.WriteLine("O nome passado como parâmetro é: " + nome);
       Console.WriteLine("O nome do atributo é: " + this.nome);
    }
}