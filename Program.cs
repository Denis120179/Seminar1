﻿/*
Задача 1
Напишите программу, которая на вход принимает два числа и выдает, какое число большее
*/

Console.WriteLine("Введите первое число:  ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:  ");
int b = int.Parse(Console.ReadLine()!);
if(a>b)
{
    Console.WriteLine($"{a} больше {b}");
}
else 
{
    Console.WriteLine($"{b} больше {a}");
}