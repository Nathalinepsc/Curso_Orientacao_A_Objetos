using System;

namespace _05Acesso
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Produto p = new Produto();
            p.nome = "Coca-cola";
            //p.valor = 5.00; // Não é possível acessar o atributo valor, pois ele é privado
        }
    }

}