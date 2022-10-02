/*
Задача 1
Напишите программу, которая на вход принимает два числа и выдает, какое число большее
*/

/*Console.WriteLine("Введите первое число:  ");
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
}*/

/*
Задача 2
Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел
*/

Console.WriteLine("Введите первое число:  ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:  ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:  ");
int c = int.Parse(Console.ReadLine()!);
if(a>b)
{
    if(a>c)
    {
        Console.WriteLine($"{a} максимальное число");            
    }
    else
    {
        Console.WriteLine($"{c} максимальное число");
    }
}
else
{
    if(b>c)
    {
        Console.WriteLine($"{b} максимальное число");        
    }
    else
    {
        Console.WriteLine($"{c} максимальное число");
    }
} 