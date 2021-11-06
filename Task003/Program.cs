// По заданному номеру дня недели вывести его название

int s; 
Console.WriteLine ("Введите число от 1 до 7:  ");
s = Convert.ToInt32(Console.ReadLine());

if (s == 1) Console.WriteLine("понедельник");
if (s == 2) Console.WriteLine("вторник");
if (s == 3) Console.WriteLine("среда");
if (s == 4) Console.WriteLine("четверг");
if (s == 5) Console.WriteLine("пятница");
if (s == 6) Console.WriteLine("суббота");
if (s == 7) Console.WriteLine("воскресенье");


