// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

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
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

void Squer (int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           if(i%2==0&& j%2==0)
           {
               array[i,j]=array[i,j]*array[i,j];
           }
        }
        
    }
}

int[,] array = new int[6,6];
SetArray(array);
PrintArray(array);
Console.WriteLine();
Squer(array);
PrintArray(array);