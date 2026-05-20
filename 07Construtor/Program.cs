using System;

namespace _07Construtor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criando uma instância da classe Pessoa usando o construtor padrão
            Pessoa pessoa1 = new Pessoa();

            // Criando uma instância da classe Pessoa usando o construtor com parâmetro
            Pessoa pessoa2 = new Pessoa("Maria");
        }
    }
}
