// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка


void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++) //строки
    {
        for (int j = 0; j < table.GetLength(1); j++) // столбцы
        {
            Console.Write($"  {table[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = new Random().Next(1, 10); //интервал от [1,10]
        }

    }
}

Console.Write("Введите количество строк: \t");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество по столбцов: \t");
int n = Convert.ToInt32(Console.ReadLine());

int[,] table = new int[m, n]; /// размерность массива 

FillArray(table);
PrintArray(table);
Console.WriteLine();
void FindStringSum(int[,] table)
{
    // одном.  массив         [4] 
    int[] sumArray = new int[table.GetLength(0)];

    for (int i = 0; i < table.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < table.GetLength(1); j++)
        {
            sum += table[i, j];
        }

        sumArray[i] = sum;
    }
    int minIndex = 0;
    int minElem = sumArray[0];
    for (int i = 0; i < sumArray.Length; i++)
    {
        if (minElem > sumArray[i])
        {
            minIndex = i;
            minElem = sumArray[i];
        }
    }
    Console.WriteLine($"Сумма = {minElem} по строке {minIndex + 1}");

}
FindStringSum(table);





