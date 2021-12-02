// Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
void Sum (int[,] array, int [,] arr, int [,] a)
{
   
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            
          
          a[i,j]=array[i,j] + arr[i,j];  
            
        }
        
    }
        PrintArray (a);
}


int[,] array = new int[6,6];
int[,] arr = new int[6,6];
int[,]a= new int[6,6];
SetArray(array);
PrintArray(array);
Console.WriteLine();
SetArray(arr);
PrintArray(arr);
Console.WriteLine();
Sum(array, arr,a);
