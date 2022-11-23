//3адайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int InputNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine() ?? "0", out int number);
        if (!result)
        {
            Console.WriteLine($"Ввод некорректный! Try again.");
            Thread.Sleep(1500);
            continue;
        }
        return number;
    }
}

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

double[] AverageColumns(int[,] array)
{
    double[] average = new double[array.GetLength(1)];

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
            average[j] = Math.Round(sum / array.GetLength(0), 1);
        }
    }
    return average;
}


int m = InputNumber($"Введите количество строк:    ");
int n = InputNumber($"Введите количество столбцов: ");
int[,] matrix = GetMatrix(m, n);
PrintMatrix(matrix);
double[] array = AverageColumns(matrix);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();