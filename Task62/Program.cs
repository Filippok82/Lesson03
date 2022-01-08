// В двумерном массиве целых чисел. Удалить строку и столбец, 
//на пересечении которых расположен наименьший элемент.


void CreadArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(1, 50);
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

void MinElement(int[,] array, int[,] newArray)
{
    int i = 0;
    int j = 0;
    int i1 = 0; ;
    int j1 = 0; ;
    int min = array[i, j];
    int mini = 0;
    int minj = 0;
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) {min = array[i, j]; mini = i; minj = j;}

        }

    }
    Console.WriteLine( $" {array[mini,minj]}");

    Console.WriteLine("Преобразованная матрица:");

    for (i = 0; i < newArray.GetLength(0); i++)
    {
        if (i >= mini)
        {
            i1 = i + 1;
        }
        else if (i < mini)
        {
            i1 = i;
        }
        for (j = 0; j < newArray.GetLength(1); j++)
        {
            if (j >= minj)
            {
                j1 = j + 1;
            }
            else if (j < minj)
            {
                j1 = j;
            }
            newArray[i, j] = array[i1, j1];
            Console.Write($"{ newArray[i, j],4}");
        }
        Console.Write("\n");
    }

}


int[,] array = new int[5, 5];
int[,] newArray = new int[4, 4];
CreadArray(array);
PrintArray(array);
MinElement(array, newArray);





