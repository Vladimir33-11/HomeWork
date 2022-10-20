// ввод трехзначное число? вывод вторая цифра числа
Console.WriteLine(" Введите трехзначное число");
int a;
int.TryParse(Console.ReadLine(), out a);
Console.WriteLine($"{(a-a/100*100)/10}");

