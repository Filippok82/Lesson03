// //  Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.

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


 void SumColumn(int[,] array)
{
    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum=0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
         {sum=sum+array[i,j]; Console.Write($"{array[i,j]} + " );} 
            
        }
        Console.WriteLine($" = {sum/array.GetLength(0),2:F2}"); // как добавить знаки после запятой
    }

}

int[,] array = new int[3, 3];

SetArray(array);
PrintArray(array);
Console.WriteLine();
SumColumn(array);





/* void SumColumn(int[,] array, double sum1, double sum2, double sum3)// Решение с магическими числами
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            if (i<array.GetLength(1)&&j==0)
            {
                sum1 += array[i, j];j++;    
                           
            }
            if (i<array.GetLength(1)&&j==1)
            {
                sum2 += array[i, j];j++;            
            }
            if (i<array.GetLength(1)&&j==2)
            {
                sum3 += array[i, j];j++;            
            }
        
        }

    }
    Console.WriteLine($"{sum1/array.GetLength(1),2} {sum2/array.GetLength(1),2} {sum3/array.GetLength(1),2}" );
}


SumColumn(array, sum1, sum2, sum3); // Решение с магическими числами
double sum1 = 0;
double sum2 = 0;
double sum3 = 0;

 */