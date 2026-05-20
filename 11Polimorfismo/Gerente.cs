using System;

class Gerente : Imposto
{
    
    // Metodo
        public override void valeAlimentacao(double salario)
    {
          Console.WriteLine("Desconto Gerente do Vale Alimentação R$ " + (salario * 0.15));
    }

}