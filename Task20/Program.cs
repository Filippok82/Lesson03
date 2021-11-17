// 20. Ввести номер четверти, показать диапазоны для возможных координат
Console.WriteLine("Выберите  номер четверти №1; №2; №3; №4");
double x; 
x = Convert.ToInt32(Console.ReadLine());

if (x == 2) Console.WriteLine("Диапазон возможных координат x < 0 & Y > 0");
if (x == 1) Console.WriteLine("Диапазон возможных координат x > 0 & Y > 0");
if (x == 3) Console.WriteLine("Диапазон возможных координат x < 0 & Y < 0");
if (x == 4) Console.WriteLine("Диапазон возможных координат x > 0 & Y < 0");