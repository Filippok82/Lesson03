// 43. Написать программу преобразования десятичного числа в двоичное


Console.Write("Введите число :");
int num =Convert.ToInt32(Console.ReadLine());
string BinaryCode = Convert.ToString(num, 2);

Console.WriteLine($" В двоичной системе исчесления : {BinaryCode}");




