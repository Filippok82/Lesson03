// Показать двумерный массив размером m×n заполненный целыми числами

void SetArray(int[,] array)
{
    Random random = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-100, 100);
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }

}
int[,] array = new int[5,5];
SetArray(array);
