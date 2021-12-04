// 58.  Написать программу, которая в двумерном массиве заменяет строки на столбцы 
//или сообщить(транспонирование матрицу 2х3 превратить на 3х2)

void SetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4}");
        }
        Console.WriteLine();
    }
}




/* void ChangeLineColumn(int[,] array) // Решение если матрица кавадратная

{
    for (int i = 0; i < array.GetLength(0); i++)

    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            Console.Write($"{array[j, i],4}");

        }
        Console.WriteLine();
    }

}

 */


 void ChangeLineColumn(int[,] array) // матрицу из 2х3 превратить на 3х2

{
    int n = array.GetLength(1)-array.GetLength(0);
    for (int i = 0; i < array.GetLength(0)+n; i++)

    {

        for (int j = 0; j < array.GetLength(1)-n; j++)
        {

            Console.Write($"{array[j, i],4}");

        }
        Console.WriteLine();
    }

}



int[,] array = new int[2, 3];


SetArray(array);
PrintArray(array);

Console.WriteLine();
ChangeLineColumn(array);


