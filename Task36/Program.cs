//36. Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
int[] array = new int[10];
Random random = new Random();
int n = 0;
int m = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(100, 1000);
    Console.WriteLine(array[i]);
}
for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0)
    {
        n++;
        

    }

    else
    {
        m++;
        

    }



}
Console.WriteLine("Четных: " + n + " Нечетных: " + m );


