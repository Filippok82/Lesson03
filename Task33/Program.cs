// 33. Задать массив из 12 элементов, заполненных числами из [-9,9]. Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
Random random = new Random();
int sum = 0;
int sum1 =0;
for (int i = 0; i < array.Length; i++)
{

    array[i] = random.Next(-9, 10);
}
for (int i = 0; i < array.Length; i++)
{
    Console.WriteLine(array[i] + " ");
    if (array[i] > 0)
    {
        sum = sum + array[i];
    }
    else
    {
        sum1 = sum1 + array[i];
    }


}
Console.WriteLine("Сумма положительных чисе: " + sum);
Console.WriteLine("Сумма отрицательных чисел: " + sum1);

