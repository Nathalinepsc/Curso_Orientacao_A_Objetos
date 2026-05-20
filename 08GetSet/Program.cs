using System;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando um objeto da classe Pessoa
            Pessoa pessoa = new Pessoa();

            // Usando o Set para atribuir um valor ao atributo Nome
            pessoa.Nome = "João";

            // Usando o Get para obter o valor do atributo Nome
            Console.WriteLine("O nome da pessoa é: " + pessoa.Nome);
        }
    }
}
