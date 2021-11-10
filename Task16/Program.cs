// 16. Дано число обозначающее день недели. Выяснить является номер недели выходным днём

int s; 
Console.WriteLine ("Введите число от 1 до 7:  ");
s = Convert.ToInt32(Console.ReadLine());

if (s < 6) Console.WriteLine("Будни");
if (s >= 6) Console.WriteLine("Выходной");


