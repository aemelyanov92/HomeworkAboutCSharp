Семинар 1. С#
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
int max;
int min;
if (num1 > num2)
{
max = num1;
min = num2;               
}
else
{
max = num2;
min = num1;
}
Console.WriteLine("макс число : {0}", max);
Console.WriteLine("мин. число : {0}", min);

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Нахождение наибольшего из трех чисел");
Console.Write("Введите первое число ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число ");
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;
if (num1>num2)
{
    max = num1;
    
}
else
{
    max = num2;
}
if (num2 > num3)
{
    max = num2;
}
else
{
    max = num3;  
}
Console.WriteLine("Максимальное из трёх чисел = " + max);


Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0) Console.WriteLine("Число делится на 2");
else Console.WriteLine("Остаток равен " + number%2);


Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine()); 
for (int x = 1; x < N+1; x++)       
if (x%2 == 0)            
Console.WriteLine(x);