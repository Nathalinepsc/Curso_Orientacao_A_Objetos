using System;

class Pessoa
{
    // Atributos
    public string Nome;
    public double Peso, Altura;

    // Calculo IMC
    public double calculoIMC()
    {
        return Peso / (Altura * Altura);
    }

    // Situação do IMC
    public string situacaoIMC(double imc)
    {
        if (imc < 18.5)
            return "Abaixo do peso";
        else if (imc < 25)
            return "Peso normal";
        else if (imc < 30)
            return "Acima do Peso";
        else if (imc < 35)
            return "Obesidade grau I";
        else if (imc < 40)
            return "Obesidade grau II";
        else
            return "Obesidade grau III";
    }

    // Mensagem
    public void mensagem()
    {
        // Obter o Calculo do IMC
        double obterCalculo = calculoIMC();

        // Obter a situação do IMC
        string obterSituacao = situacaoIMC(obterCalculo);

        // Mensagem
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Peso: {Peso} kg");
        Console.WriteLine($"Altura: {Altura} m");
        Console.WriteLine($"IMC: {obterCalculo:F2}");
        Console.WriteLine($"Situação: {obterSituacao}");
        Console.WriteLine();
    }
}