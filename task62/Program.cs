/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07  */

int[,] FillSpiralArray(int m, int n)
{
    int[,] array = new int[m, n];
    int count = 1; // счетик для остановки и старта массива
    int positionY = 0;
    int positionX = 0;
    int lenghtToRight = n - 1;
    int lenghtToDown = m - 1;
    int lenghtToLeft = 0;
    int lenghtToUp = 1;
    bool turnRight = true;
    bool turnDown = false;
    bool turnLeft = false;
    bool turnUp = false;
    while (count <= (m * n))
    {
        if (turnRight)
        {
            array[positionY, positionX] = count;
            if (positionX == lenghtToRight)
            {
                turnDown = true;
                turnRight = false;
                positionY++;
                lenghtToRight--;
                count++;
                goto endLoop;

            }
            positionX++;
        }
        if (turnDown)
        {
            array[positionY, positionX] = count;
            if (positionY == lenghtToDown)
            {
                lenghtToDown--;
                positionX--;
                turnDown = false;
                turnLeft = true;
                count++;
                goto endLoop;

            }
            positionY++;
        }
        if (turnLeft)
        {
            array[positionY, positionX] = count;
            if (positionX == lenghtToLeft)
            {
                lenghtToLeft++;
                turnUp = true;
                turnLeft = false;
                positionY--;
                count++;
                goto endLoop;

            }
            positionX--;
        }
        if (turnUp)
        {
            array[positionY, positionX] = count;
            if (positionY == lenghtToUp)
            {
                lenghtToUp++;
                turnUp = false;
                turnRight = true;
                positionX++;
                count++;
                goto endLoop;
            }
            positionY--;
        }
        count++;
    endLoop: continue;
    }
    return array;
}


void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Задача 5");
Console.Write("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество стобцов двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] mas6 = FillSpiralArray(m, n);
PrintArray(mas6);