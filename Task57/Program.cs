
// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

void SetArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            a[i, j] = new Random().Next(1, 20);
        }
    }
}

void Print(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j],4}");
        }
        Console.WriteLine();
    }
}




void Sort(int[,] a) //сортировка пузырьком каждой строки массива
{
    int tmp;
    
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            for (int m=1; m<a.GetLength(1)-j; m++)
            {
                if (a[i,m]>a[i,m-1])
                {
                tmp=a[i,m]; 
                a[i,m]=a[i,m-1];
                a[i,m-1]=tmp;
                }
            }
        }   
    }
}
int m = 4;
int n = 4;
int[,] a;
a = new int[m, n];

SetArray(a);
Print(a);

Sort(a);

Console.WriteLine();
Print(a);
