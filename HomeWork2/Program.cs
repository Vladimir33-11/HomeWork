//  Задача 2 Программа на вход 3 числа, вывод максимального 
int a,b,c;

Console.WriteLine("Введите первое число: ");
a=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
b=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
c=int.Parse(Console.ReadLine()!);
int max = a;
if (max<b)
{
   max = b;
}
if (max<c)
{
    max = c;
}
Console.WriteLine($"max={max}");
