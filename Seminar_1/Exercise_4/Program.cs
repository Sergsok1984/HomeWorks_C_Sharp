﻿// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите три числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"Максимальное число: {a}");    
}
else if (b > c)
{
    Console.WriteLine($"Максимальное число: {b}");   
}
else 
{
    Console.WriteLine($"Максимальное число: {c}"); 
}
