﻿// Сформировать трехмерный массив не повторяющимися двузначными числами 
//показать его построчно на экран выводя индексы 
void CreadArray3D(int[,,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = random.Next(10, 50);
            }
        }

    }
}

void PrintArray3D(int[,,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = 0; k < array.GetLength(2); k++)
            {

                Console.Write($"{i}|{j}|{k}  ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,,] array = new int[3, 3, 3];
CreadArray3D(array);
PrintArray3D(array);