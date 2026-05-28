namespace testes.exercicios_basicos;
using System.Text;
using System;
public class Sb
{
    public static void Executar()
    {
        var sb = new StringBuilder();
        sb.Append("Ola");
        sb.Append(" ");
        sb.Append("estou");
        sb.Append(" ");
        sb.Append("estudando");

        for (int i = 0; i < 6; i++)
        {
            sb.AppendLine(i.ToString());
            Console.WriteLine(sb.ToString());
        }
    }
}