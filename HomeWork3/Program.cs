//  программа на ввод число, вывод четное или нечетное
int a;
Console.WriteLine("Введите число: ");
a=int.Parse(Console.ReadLine());
if (a%2==0)
{
    Console.WriteLine("Четное! ");
}
else
{
    Console.WriteLine("Нечетное! ");
}