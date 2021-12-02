// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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


void Element(int[,] array, int a)
{
    bool found = false;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a == array[i, j])
            {
                Console.WriteLine($"Такое число есть в массиве его позиция: {i} {j}");
                found = true;
            }
        }
    }

    if (!found)
    {
        Console.WriteLine("Такого числа нет в массиве");
    }

}


int[,] array = new int[9, 9];
int a = 0;
SetArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
Element(array, a);
