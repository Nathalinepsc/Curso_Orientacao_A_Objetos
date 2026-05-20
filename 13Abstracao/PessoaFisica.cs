using System;

class PessoaFisica : Padrao
{

    // Metodo Obrigatorio
    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de empréstimo para Pessoa Física R$ " + (valor * 0.1));
    }

}