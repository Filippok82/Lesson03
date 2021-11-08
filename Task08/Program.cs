// 8. Показать четные числа от 1 до N
Console.WriteLine("Введите число N ");
int n;
n = Convert.ToInt32(Console.ReadLine());

int i;
for (i = 0; i <= n; ++i)
{
    if (i % 2 == 0)
    {
    Console.Write(i + " ");
    }
    
}