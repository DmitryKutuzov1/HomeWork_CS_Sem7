// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

void FindElement(int[,] matrix, int position)
{
    int row = position / 10;
    int column = position % 10;
    if (row > matrix.GetLength(0) || column > matrix.GetLength(1))
        Console.WriteLine("Такого числа в массиве нет.");
    else
    {
        Console.WriteLine($"Искомое число ({row}, {column}) -> {matrix[row, column]}");
    }
}

void Print2DArray(int[,] matrix)
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

int[,] Fill2DArray(int rows, int columns, int startValue, int finishValue)
{
    int[,] matrix = new int[rows, columns];
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
int position = GetImput("Введите номера столбца и колонны без разделительных знаков: ");
int[,] array = Fill2DArray(m, n, 1, 10);
Print2DArray(array);
FindElement(array, position);