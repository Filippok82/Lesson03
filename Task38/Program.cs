// 38. Найти сумму чисел одномерного массива стоящих на нечетной позиции
int [] array = new int [10];
Random random = new Random();
int sum=0;
for(int i =1;i<array.Length; i++)
{
    array[i]= random.Next(0,100);
    Console.WriteLine(array[i] + " ");

 if(i%2!=0)
    {
        sum+=array[i];
        /* Console.WriteLine(array[i] + " " ); */
    }
   
}

Console.WriteLine( "Сумма чисел, стоящих на нечетных позициях = " + sum);





