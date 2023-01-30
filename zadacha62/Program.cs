// // Задача 62: Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void FillArray(int[,] matrix)
{
    int number = 1;
    for (int i = 0; i < 1; i++)
    {        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = number;
            number++;
        }
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 3; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = number-1;
            number++;
        }
    }
    for (int i = 3; i < matrix.GetLength(0); i++)
    {
        for (int j = 3; j >= 0; j--)
        {
            matrix[i, j] = number-2;
            number++;
        }
    }
    for (int i = 2; i > 0; i--)
    {        
        for (int j = 0; j < 1; j++)
        {
            matrix[i, j] = number-2;
            number++;
        }
    }
    for (int i = 1; i < 2; i++)
    {        
        for (int j = 1; j < 3; j++)
        {
            matrix[i, j] = number-2;
            number++;
        }
    }
    for (int i = 2; i < 3; i++)
    {
        for (int j = 2; j < 3; j++)
        {
            matrix[i, j] = number-2;
            number++;
        }
    }
    for (int i = 2; i <= 2; i++)
    {
        for (int j = 1; j >= 1; j--)
        {
            matrix[i, j] = number-2;
            number++;
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

int m1 = 4;
int n1 = 4;

int[,] matrix1 = new int[m1, n1];
FillArray(matrix1);
Console.WriteLine("Ваша матрица:");
PrintArray(matrix1);
