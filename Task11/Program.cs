// 11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int n = new Random().Next(10,99);
Console.WriteLine(n);
int s = n%10;
int f = (n - s)/10;
if (f > s)
{
    Console.WriteLine(f + " наибольшая цифра числа " + n);
}
else 
{ 
    Console.WriteLine(s + " наибольшая цифра числа " + n);
}