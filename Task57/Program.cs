
// 57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

/* void SetArray(int[,] a)
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
 */
//------------------------------ вариант с семинара
int[,] a=new int[4,4];

void Print(int[,] array)
{
    for(int i=0;i<array.GetLength(0);i++){
        for(int j=0;j<array.GetLength(1);j++)
            System.Console.Write($"{array[i,j],4}");
        System.Console.WriteLine();
    }
}

void SetArrayRandom(int[,] array)
{
    Random random=new Random();
    for(int i=0;i<array.GetLength(0);i++){
        for(int j=0;j<array.GetLength(1);j++)
            array[i,j]=random.Next(0,100);        
    }
}
    int[,] array=new int[4,4];
void Sort2DArray(int[,] array)
{

    
    for(int i=0;i<array.GetLength(0);i++)
    {
        for(int j=0;j<array.GetLength(1);j++)
        {
            int iMin=i;
            int jMin=j;

            for(int i1=i;i1<array.GetLength(0);i1++)
            {
                int startJ;
                if (i1==i) startJ=j; else startJ=0;

                 for(int j1=startJ;j1<array.GetLength(1);j1++)
                 {
                    if (array[iMin,jMin]>array[i1,j1])
                    {
                        iMin=i1;
                        jMin=j1;
                    }
                 }
                 
            }
            int t=array[i,j];
            array[i,j]=array[iMin,jMin];
            array[iMin,jMin]=t;
            Print(array);
            System.Console.WriteLine();
            Console.ReadKey();
        }
    }
}


SetArrayRandom(a);
Print(a);
//Array.Sort(a);
System.Console.WriteLine( );
Sort2DArray(a);
Print(a);



//_________________________________________________________________от Семена Овчарова
/* void SortArray(int[] sortArr)
{
    int temp;
    for (int n = 0; n < sortArr.Length; n++)
    {
        for (int m = 0; m < sortArr.Length - 1; m++)
        {
            if (sortArr[m] < sortArr[m + 1])
            {
                temp = sortArr[m + 1];
                sortArr[m + 1] = sortArr[m];
                sortArr[m] = temp;
            }
        }
    }
}

int[] CreateFromSquare2DTo1DArray(int[,] Arr2D)
{
    int n = Arr2D.GetLength(0);
    int m = Arr2D.GetLength(1);
    int[] newArr = new int[Arr2D.GetLength(0) * Arr2D.GetLength(1)];
    int ratio = Arr2D.GetLength(0);
    for (int i = 0; i < Arr2D.GetLength(0); i++)
    {
        for (int j = 0; j < Arr2D.GetLength(1); j++) newArr[m*i+j] = Arr2D[i, j];
    }
    return newArr;
}
void FillFrom1DToSquare2DArray(int[] Arr, int[,] Arr2D)
{
    for (int n = 0, i = 0; n < Arr2D.GetLength(0); n++)
    {
        for (int m = 0; m < Arr2D.GetLength(1); m++, i++)
        {
            Arr2D[n, m] = Arr[i];
        }
    }
}

int[,] Arr2D68 = FrameworkTo2DArray();
Print2DArray(Arr2D68);
int[] newArr = CreateFromSquare2DTo1DArray(Arr2D68);
SortArray(newArr);
foreach (int n in newArr) System.Console.Write($"{n} ");
FillFrom1DToSquare2DArray(newArr, Arr2D68);
Console.WriteLine();
Print2DArray(Arr2D68);

 */
