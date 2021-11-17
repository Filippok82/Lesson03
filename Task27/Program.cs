//27. Определить количество цифр в числе

Console.WriteLine("Веедите целое число");

int num = Convert.ToInt32(Console.ReadLine());
int b = 0;

while ( num != 0)
{
     num = num /10;
     b ++;
}
Console.WriteLine("количество цифр в числе:" + b);
