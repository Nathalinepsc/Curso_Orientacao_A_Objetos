using System;

class Colaborador : Pessoa
{
    // Atributos
    private string cargo;
    private double salario;

    // Construtor
    public Colaborador(string nome, int idade, string cargo, double salario)
    {
        this.nome = nome;
        this.idade = idade;
        this.cargo = cargo;
        this.salario = salario;

        mensagemPessoa();
        mensagemColaborador();
    }

    // Metodo
    private void mensagemColaborador()
    {
        Console.WriteLine($"Cargo: {cargo}");
        Console.WriteLine($"Salário: {salario:C}");
    }
}