//61. Найти произведение двух матриц

void SetArray1(int[,] array)
{
    System.Random random = new System.Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(0, 10);
        }

    }

}
void PrintArray1(int[,] array)
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

void SetArray2(int[,] arr)
{
    System.Random random = new System.Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 10);
        }

    }

}
void PrintArray2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write(arr[i, j] + " ");
        }
        System.Console.WriteLine();
    }

}

void MultiplyaArray(int[,] array, int[,] arr)

{
    for (int i = 0; i < array.GetLength(0)&&i< arr.GetLength(0); i++)
        
        {

            for (int j = 0; j < array.GetLength(1)&& j<arr.GetLength(1); j++)
                {
                    
                    

                        System.Console.Write($"{array[i,j]*arr[i,j]} ");
                    
                }

            System.Console.WriteLine();
        }

}


int[,] array = new int[3, 4];
int[,] arr = new int[3, 4];
SetArray1(array);
PrintArray1(array);
System.Console.WriteLine();
SetArray2(arr);
PrintArray2(arr);
 System.Console.WriteLine();
MultiplyaArray(array, arr); 
