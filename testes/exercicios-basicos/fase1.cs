namespace testes.exercicios_basicos;
using System;

public class fase1
{
    public static void Executar()
    {
        
        string nome = "Maria";
        int idade = 35;
        string altura = "3,45";
        string data = "04/09/1999";
        const string ano = "12";
        double? nota = 7.80;
        DateTime hoje = DateTime.Now;
        DateTime hj = new DateTime(2026, 05, 27);
        object a = "10";
        dynamic n = "Meu nome é Caue e eu amo a mãe dos meus filhos, nome dela é Maria Fernanda";
        int x = 77;
        int y = 66;
        Console.WriteLine($"{idade}");
        Console.WriteLine($"{nome}");
        Console.WriteLine($"{altura}");
        Console.WriteLine($"{data}");
        Console.WriteLine($"{ano}");
        Console.WriteLine($"{nota}");
        Console.WriteLine($"{hoje}");
        Console.WriteLine($"{a}");
        Console.WriteLine($"{n}");
        Console.WriteLine($"{hj}");
        Console.WriteLine($"{x+y}");
    }
}