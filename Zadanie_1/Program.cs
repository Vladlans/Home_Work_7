//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
int InputNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine() ?? "0", out int number);
        if (!result)
        {
            Console.WriteLine($"Некорректные данные!");
            Thread.Sleep(1000);

            continue;
        }
        return number;
    }
}

double[,] GetArrayOfRealNumbers(int m, int n)
{
    double[,] array = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(-100,100), 1);  //* 100, 1);
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int m = InputNumber("Введите число строк:    m = ");
int n = InputNumber("Введите число столбцов: n = ");
PrintArray(GetArrayOfRealNumbers(m, n));