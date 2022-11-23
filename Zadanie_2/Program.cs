//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
int[,] GetMatrix()
{
    int rows = new Random().Next(2, 10);
    int columns = new Random().Next(2, 10);

    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
        Console.WriteLine();
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int InputNumber(string message)
{
    while (true)
    {
        Console.Write(message);
        bool result = int.TryParse(Console.ReadLine() ?? "0", out int number);
        if (!result || number <= 0)
        {
            Console.WriteLine($"Некорректный ввод! ");
            Thread.Sleep(1500);

            continue;
        }
        return number;
    }
}

bool CheckPosition(int[,] matrix, int row, int column)
{
    bool result = row - 1 <= matrix.GetLength(0) && column - 1 <= matrix.GetLength(1);

    return result;
}

int[,] arr = GetMatrix();
PrintMatrix(arr);
Console.WriteLine();

int m = InputNumber($"Введите номер ряда");
int n = InputNumber($"Введите номер столбца");
Console.WriteLine();

Console.WriteLine(CheckPosition(arr, m, n)
? $"Значение элемента {arr[m - 1, n - 1]}" : "Такого числа в массиве нет");