using System;

namespace _04ExercicioIMC
{
    class Program
    {
        static void Main()
        {
            // Instanciar um objeto
            Pessoa pessoa1 = new Pessoa();
            pessoa1.Nome = "Laura";
            pessoa1.Peso = 65.0;
            pessoa1.Altura = 1.65;
            pessoa1.mensagem();
        }
    }
}
