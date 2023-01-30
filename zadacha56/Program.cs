// Задача 56. Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 4 6 7
// Программа считает сумму элементов в каждой строке и выдает
// номер строки с наименьшей суммой элементов: 1 строка

void FillArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }

    }
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] SumArray(int[,] matrix, int[] array)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

int NumberString(int[] array)
{
    int min = array[0];
    int str = 1;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i] < min)
        {
            min = array[i];
            str = i + 1;
        }
    }
    return str;
}

Console.WriteLine("Введите число строк:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов:");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
int[] array = new int[m];
FillArray(matrix);
Console.WriteLine("Исходный массив:");
PrintArray(matrix);

array = SumArray(matrix, array);
Console.WriteLine();
Console.WriteLine("Построчная сумма:");
Console.WriteLine(string.Join(", ", array));

Console.WriteLine();
int str = NumberString(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {str}");