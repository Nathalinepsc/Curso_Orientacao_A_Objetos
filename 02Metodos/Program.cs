using System;

namespace _02Metodos;

class Program
{
    static void Main(string[] args)
    {
       Pessoa obj = new Pessoa();
        obj.Apresentar();
        obj.Apresentar("Maria");
        obj.Apresentar("Maria", 30);
    }
}
