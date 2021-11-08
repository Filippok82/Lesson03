//  9. Показать последнюю цифру трёхзначного числа
Console.WriteLine("Введите техзначное число");
int c,a;
a = Convert.ToInt32(Console.ReadLine());
c = a % 10;
Console.WriteLine("Последня цифра числа  " + a + " " + c);