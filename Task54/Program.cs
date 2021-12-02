// В матрице чисел найти сумму элементов главной диагонали
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


void SumDiagonal(int[,] array, int sum1, int sum2)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i == j)
            {
                sum1 = array[i, j];

                sum2 += sum1;
                                
                
            }
            
        }

    
    }
Console.WriteLine("Сумма элементов главной диагонали:"+ sum2);
}


int[,] array = new int[5, 5];
int sum1 = 0;
int sum2 = 0;
SetArray(array);
PrintArray(array);
Console.WriteLine();
SumDiagonal(array, sum1, sum2);
