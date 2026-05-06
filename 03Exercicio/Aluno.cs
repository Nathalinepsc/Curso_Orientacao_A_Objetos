using System;

class Aluno
{
    // Atributos
    public string Nome;
    public double Nota1, Nota2, Nota3;

    // Média
    public double media()
    {
        return (Nota1 + Nota2 + Nota3) / 3;
    }

    // Situação do aluno
    public string situacao(double media)
    {
        return media >= 7 ? "Aprovado" : "Reprovado";
    }

    // Mensagem
    public void mensagem()
    {
        // Obter a média
        double obterMedia = media();

        // Obter a situação
        string obterSituacao = situacao(obterMedia);

        // Mensagem
        Console.WriteLine($"Aluno {Nome} está {obterSituacao} com média {obterMedia:F2}.");

    }

}
