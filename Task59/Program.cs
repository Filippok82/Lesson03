//59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

void SetArray(int[,] array)
{
   System. Random random = new System.Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 50);
        }

    }

}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}

void MinSunLine(int[,] array)
{


    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {

            {

                sum = sum + array[i, j];
              


            }

        }
        System.Console.WriteLine(sum);
    }


}


int[,] array = new int[3, 4];

SetArray(array);
PrintArray(array);
System.Console.WriteLine();
MinSunLine(array);