// 10. Показать вторую цифру трёхзначного числа
Console.WriteLine("Введите техзначное число");
int c,a;
a = Convert.ToInt32(Console.ReadLine());
c = (a % 100)/10;
Console.WriteLine("Вторая цифра числа  " + a + " " + c);