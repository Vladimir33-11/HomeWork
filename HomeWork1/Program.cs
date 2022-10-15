//  Задача 2 Программа на вход 2 числа, вывод максимального и минимального
int a,b;
string c,d;
Console.WriteLine("Введите первое число: ");
a=int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
b=int.Parse(Console.ReadLine()!);
if (a>b)
{
    Console.WriteLine($"max={a},min={b}");
}
else if(a==b)
{
    Console.WriteLine($"введенные числа равны");
}
else
{
    Console.WriteLine($"max={b},min={a}");
}