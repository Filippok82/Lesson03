// 17. По двум заданным числам проверять является ли одно квадратом другого

double s,a;
Console.WriteLine("Ввведите первое число:" );
s = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число:" );
a = Convert.ToInt32(Console.ReadLine());
double s1 = Math.Pow(s,2);
double a1 = Math.Pow(a,2);


if (s == a1)
{
    Console.WriteLine("Второе число является квадратом первого");
}

if (a == s1)
{
  Console.WriteLine("Первое число является квадратом второго"); 
}
else
{
  Console.WriteLine("Число не являются квадратом другого");   
}
