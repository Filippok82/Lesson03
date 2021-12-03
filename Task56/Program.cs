//56. Написать программу, которая обменивает элементы первой строки и последней строки

void SetArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 100);

        }

    }

}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],4} ");
        }
        Console.WriteLine();
    }
}


void ChangeString(int[,] array)
{
    int tmp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int x = array.GetLength(0) - 1;
            if (i == x)
            {
                tmp = array[i, j];
                array[i, j] = array[i - x, j];
                array[i - x, j] = tmp; 
    }
            }
        
        }


}




int[,] array = new int[5, 5];
SetArray(array);
PrintArray(array);
Console.WriteLine();
ChangeString(array);
PrintArray(array);