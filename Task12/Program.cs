/// 12. Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите техзначное число");
int b, c, a;
a = Convert.ToInt32(Console.ReadLine());
c = a - a % 100 + a % 10;
Console.WriteLine("Способ №1  "+ c);
b = a / 100 * 10 + a % 10;
Console.WriteLine("Способ №2  " + b);


