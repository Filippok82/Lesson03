﻿//64.Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника


int i=0;
int c=0;
Console.WriteLine("Введите количество строк: ");
int n= Convert.ToInt32(Console.ReadLine());

float factorial(int n)
        {
            float i, x = 1;
            for (i = 1; i <= n; i++)
            {
                x *= i;
            }
            return x;
        }
        for (i = 0; i < n; i++)
            {
                for (c = 0; c <= (n - i); c++) // создаём после каждой строки n-i отступов от левой стороны консоли, 
                {                               //чем ниже строка, тем меньше отступ
                    Console.Write(" "); 
                }
                for (c = 0; c <= i; c++)
                {
                    Console.Write(" "); // создаём пробелы между элементами треугольника
                    Console.Write(factorial(i) / (factorial(c) * factorial(i - c))); //формула вычисления элементов треугольника
                }
                Console.WriteLine();
                Console.WriteLine(); // после каждой строки с числами отступаем две пустые строчки
            }
