//7. Показать числа от -N до N

Console.WriteLine("Введите число -N");
int minN;
minN = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int maxN;
maxN = Convert.ToInt32(Console.ReadLine());


int index;
index = minN;
while (index <= maxN)
{
    Console.Write(index + " ");
    index++;
}