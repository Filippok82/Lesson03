// 25. Найти сумму чисел от 1 до А
int b = 27;
int[] a = new int[b];// Создание массива
Random random;//Описание random
random = new Random();//Создание random 
for (int i = 1; i < b; i++)
{
    a[i] = random.Next(0, 100);
}
for (int i = 1; i < b; i++)
{
    Console.WriteLine(a[i] + " ");
}
int Sum = 0;
for (int i = 0; i < b; i++)
{
    Sum += a[i];
}
Console.Write("Сумма чисел в массиве = " + Sum);