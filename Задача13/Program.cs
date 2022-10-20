// ввод числa - вывод третья цифра числа или ее нет
Console.WriteLine(" Введите число");
int a, b, c, d, i;
int.TryParse(Console.ReadLine(), out a);
i = 100; 
d= 1;
if (a/100==0)
{    Console.WriteLine($" третьей цифры нет" );
     return;
}
while (a/i > 0)
{
i=i*10;
d = d * 10;
} 
d=d/10;
c=i/100;
b=a%c;
Console.WriteLine($"третья цифра {b/d}");



