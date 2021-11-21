//40. В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int[] array = new int[10];

void CreateArray(int[] array) // Cоздание массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
int Max(int[] array)
{
    int i = 0;
    int max = array[i];
    while (i < array.Length)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        i++;
    }
    return max;

}

int Min(int[] array)
{
    int i = 0;
    int min = array[i];
    while (i < array.Length)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        i++;
    }
    return min;
}

CreateArray(array);
Console.Write("Заданный массив: ");
PrintArray(array);
Console.Write("\nРазница между максимальным и минимальным элементом: ");
Console.WriteLine(Max(array) - Min(array));

