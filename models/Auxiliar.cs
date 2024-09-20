using System;

public static class Auxiliar
{
    public static int CalcularIdade(DateTime data)
    {
        return DateTime.Now.Year - data.Year;
    }

    public static string FaixaEtaria(int idade)
    {
        if (idade <= 11) return "Criança";
        if (idade >= 12 && idade <= 21) return "Jovem";
        if (idade >= 22 && idade <= 59) return "Adulto";
        return "Idoso";
    }
}
