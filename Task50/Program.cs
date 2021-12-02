// В двумерном массиве n×k заменить четные элементы на противоположные

void SetArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100, 100);
            
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

void EvenChangeNeg (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i,j]%2==0)
            {
                int a=array[i,j];
                a = a*-1;
                array[i,j]=a;
            }

            
        }
        
    }

}


int[,] array = new int[5,5];
SetArray(array);
PrintArray(array);
Console.WriteLine();
EvenChangeNeg(array);
PrintArray(array);
