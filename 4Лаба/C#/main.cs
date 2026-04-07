using System;
using Lib; 

class Program
{
    static void Main()
    {
        ExpressionCalculator[] calculations = {
            new ExpressionCalculator(10, 2, 5, 1),   
            new ExpressionCalculator(5, 0, 10, 10), 
            new ExpressionCalculator(1, 1, 100, 1)  
        };

        Console.WriteLine("--- Початок обчислень (C#) ---");
        foreach (var item in calculations)
        {
            try
            {
                double result = item.CalculateResult();
                Console.WriteLine($"Результат: {result:F4}"); 
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ПІЙМАНА ПОМИЛКА: {ex.Message}");
            }
        }
        
        Console.WriteLine("--- Роботу завершено ---");
    }
}