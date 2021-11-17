//28. Подсчитать сумму цифр в числе

Console.WriteLine("Веедите целое число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (0 < num)
{
    sum += num % 10;
    num /= 10;
}
Console.WriteLine("сумма цифр в числе:" + sum);
