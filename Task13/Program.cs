// 13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
double  a = new Random().Next(1, 999); 
Console.WriteLine("Заданное число "+ a);
double b;
Console.WriteLine("Введите число ");
b =Convert.ToInt32(Console.ReadLine());
double result = a / b;
if (a % b ==0)
{
    Console.WriteLine("Кратно");
}
else
{
    Console.WriteLine("Остаток = " + a % b);
}


