// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void ShowAverage(double[,] matrix, int rows, int columns)
{
    double average = 0;
    Console.Write("Среднее арифметическое каждого столбца: ");
    for (int i = 0; i < matrix.GetLength(1) - 1; i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average = average + matrix[j, i] / rows;
        }
        Console.Write($"{Math.Round(average, 2)}; ");
        average = 0;
    }
    for (int j = 0; j < matrix.GetLength(0); j++)
        {
            average = average + matrix[j, columns - 1] / rows;
        }
    Console.Write($"{Math.Round(average, 2)}.");
    Console.WriteLine();
}

void Print2DArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

double[,] Fill2DArray(int rows, int columns, int startValue, int finishValue)
{
    double[,] matrix = new double[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(startValue, finishValue);
        }
    }
    return matrix;
}

int GetImput(string text)
{
    Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int m = GetImput("Введите колличество строк: ");
int n = GetImput("Введите колличество столбцов: ");
double[,] array = Fill2DArray(m, n, 1, 10);
Print2DArray(array);
ShowAverage(array, m, n);