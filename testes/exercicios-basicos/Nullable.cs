namespace testes.exercicios_basicos;
using System;

public class Nullable
{
    public static void Executar()
    {
        double? nota = null;
        Console.WriteLine(nota);
        Console.WriteLine(nota??0);
        nota = 5;
        Console.WriteLine(nota ?? 0);

        int? n = null;
        Console.WriteLine(n);
        Console.WriteLine(n ?? 0);
        n = 10;
        Console.WriteLine(n ?? 0);
    }
}