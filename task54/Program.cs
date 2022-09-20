// Задача 54: Задайте двумерный массив. 
//Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            Console.Write($"{matr[i, j]}");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10); //интервал от [1,10]
        }

    }
}

Console.Write("Введите количество строк: \t");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество по столбцов: \t");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n]; /// размерность массива 
//PrintArray(matrix);

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();





int [,] SortMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            
            for (int n = j; n < matrix.GetLength(1); n++)
            {
                if (matrix[i,j] < matrix[i, n])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, n];
                    matrix[i, n] = temp;
                }
            }
        }
    }
    return matrix;
}


PrintArray(SortMatrix(matrix));


