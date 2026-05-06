using System;

namespace _03Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar objeto da classe Aluno
            Aluno a = new Aluno();
            a.Nome = "João";
            a.Nota1 = 8.5;
            a.Nota2 = 7.0;
            a.Nota3 = 9.0;
            a.mensagem();
        }    
    }
}