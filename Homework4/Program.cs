// программа ввод числа n; вывод все четные от 1 до n
int n,i;
Console.WriteLine("Введите число: ");
//n = int.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(),out n);
i = 2;
Console.WriteLine("Четные числа: ");
while (i<=n)
{
    Console.Write($"{ i } ");
    i=i + 2;
}