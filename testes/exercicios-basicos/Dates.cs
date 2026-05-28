namespace testes.exercicios_basicos;
using System;
public class Dates
{
        public static void Executar(){
                DateTime hoje = DateTime.Now;
                DateTime uma = new DateTime(2026, 05, 20);
                DateTime dois = new DateTime(2026, 05, 10);
                object? o = null;
                TimeSpan diff = uma - dois;
                Console.WriteLine($"{hoje}");
                Console.WriteLine(hoje.DayOfYear);
                Console.WriteLine(hoje.DayOfWeek);
                Console.WriteLine(hoje.ToLongDateString());
                Console.WriteLine(hoje.ToShortDateString());
                Console.WriteLine(hoje.ToLongTimeString());
                Console.WriteLine(hoje.ToShortTimeString());
                Console.WriteLine(hoje.Year);
                Console.WriteLine(hoje.Day);
                Console.WriteLine(hoje.Month);
                Console.WriteLine(hoje.Hour);
                Console.WriteLine(hoje.Minute);
                Console.WriteLine(hoje.Second);
                Console.WriteLine(hoje.Millisecond);
                Console.WriteLine(hoje.AddYears(2));
                Console.WriteLine(hoje.AddMonths(2));
                Console.WriteLine(hoje.AddDays(7));
                Console.WriteLine(hoje.AddHours(2));
                Console.WriteLine(hoje.AddMinutes(10));
                Console.WriteLine(diff.Days);
                
        }
}