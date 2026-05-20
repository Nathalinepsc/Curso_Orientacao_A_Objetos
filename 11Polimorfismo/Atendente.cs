using System;

class Atendente : Imposto
{
   
    // Metodo
        public override void valeAlimentacao(double salario)
    {
          Console.WriteLine("Desconto Atendente do Vale Alimentação R$ " + (salario * 0.12));
    }
 
}