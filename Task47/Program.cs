// 47. Написать программу копирования массива

int GetRandom ()
{
  return new Random().Next(1,100);
}

void PrintArray(int [] array)
{
    for (int i = 0; i < 10; i++)
    {Console.Write($"{(array[i])} ");}
    Console.WriteLine();
}

int[] B = new int [10];
int[] A = new int [10];
void CopyArray (int [] array)
{
    for (int i = 0; i < 10; i++)
    {
        B[i]= A[i]*-1; 
    }  
}

int i=0;

while (i<10)
{ A[i]=GetRandom(); i++; }

Console.WriteLine("Массив из 10 элементов  и его копия с отрицательными элементами");
PrintArray (A);
CopyArray (A); 
PrintArray(B);
 