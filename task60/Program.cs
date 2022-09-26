// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//  Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
bool [] number = new bool [100];

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) //строки
    {
        for (int j = 0; j < matr.GetLength(1); j++) // столбцы
        {
            for (int k = 0; k < matr.GetLength(2); k++) //колонки
            {
                 Console.Write($" {matr[i, j, k]} {(i,j,k)}" );
            }
           Console.WriteLine();
        }
        
    }
}

void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++)
            {
                 matr[i, j, k] = new Random().Next(10,100);
            }
        }

    }
}

Console.Write("Введите количество строк: \t");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество по столбцов: \t");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество по колонок: \t");
int x = Convert.ToInt32(Console.ReadLine());


int[,,] matrix = new int[m, n, x]; /// размерность массива 
//PrintArray(matrix);

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
