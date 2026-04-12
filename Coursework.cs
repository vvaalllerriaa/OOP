using System;
public class CharMatrix
{
    private char[,] _matrix; // Інкапсуляція

    public CharMatrix(char[,] matrix)
    {
        _matrix = (char[,])matrix.Clone();
    }

    public string this[int index] //Використання індексатора
    {
        get
        {
            if (index < 0 || index >= _matrix.GetLength(0))
                return "Помилка: індекс поза межами";

            string row = "";
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                row += _matrix[index, j];
            }
            return row;
        }
    }

    public int ConsonantCount //Використання властивості
    {
        get
        {
            string vowels = "aeiouyаеєиіїоуюя"; 
            int count = 0;

            foreach (char c in _matrix)
            {
                char lowerC = char.ToLower(c);
                if (char.IsLetter(c) && !vowels.Contains(lowerC))
                {
                    count++;
                }
            }
            return count;
        }
    }
}


class Program
{
    static void Main()
    {
        Console.Write("Кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());

        char[,] data = new char[rows, cols];

        // Заповнення масиву
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write($"Введіть символ для [{i},{j}]: ");
                data[i, j] = Console.ReadLine()[0]; 
            }
        }

        CharMatrix matrixObj = new CharMatrix(data);

        Console.Write("\nНомер рядка для виведення: ");
        int index = int.Parse(Console.ReadLine());
        Console.WriteLine("Рядок : " + matrixObj[index]);
        Console.WriteLine("Кількість приголосних літер: " + matrixObj.ConsonantCount);
    }
}