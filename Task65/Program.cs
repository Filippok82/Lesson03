// 65. Спирально заполнить двумерный массив:


class Program
{
    struct Direction
    {
        public int i;
        public int j;
    }
 
    static void Main(string[] args)
    {
        int n, m;
 
        Console.Write("Введите n: ");
        while (!Int32.TryParse(Console.ReadLine(), out n))
        {
            Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
        }
        Console.Write("Введите m: ");
        while (!Int32.TryParse(Console.ReadLine(), out m))
        {
            Console.Write("Введённое вами значение некорректное. Попробуйте ещё раз: ");
        }
 
        int[,] array = new int[n, m];
        Direction direct = new Direction() { i = 0, j = 1 };
        int count = 0;
 
        int i = 0, j = 0;
        while (count < n * m)
        {
            while ((i < n) && (i >= 0) && (j < m) && (j >=0))
            {
                if (array[i, j] == 0)
                {
                    count++;
                    array[i, j] = count;
                    i += direct.i;
                    j += direct.j;
                }
                else
                {
                    if (count == m * n) break;
                    i -= direct.i;
                    j -= direct.j;
                    ChangeDirection(ref direct);
                    i += direct.i;
                    j += direct.j;
                }
            }
 
            if (i < 0) i = 0;
            if (i >= n) i = n - 1;
            if (j < 0) j = 0;
            if (j >= m) j = m - 1;
            ChangeDirection(ref direct);
            i += direct.i;
            j += direct.j;
        }
 
        Console.WriteLine("Результат:");
        for (i = 0; i < n; i++)
        {
            for (j = 0; j < m; j++)
            {
                Console.Write($"{array[i, j],4} ");
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
 
    static void ChangeDirection(ref Direction direct)
    {
        switch (direct.i)
        {
            case -1:
                direct.i = 0;
                direct.j = 1;
                break;
            case 1:
                direct.i = 0;
                direct.j = -1;
                break;
            case 0:
                if (direct.j > 0)
                {
                    direct.i = 1;
                    direct.j = 0;
                }
                else
                {
                    direct.i = -1;
                    direct.j = 0;
                }
                break;
        }
    }
}