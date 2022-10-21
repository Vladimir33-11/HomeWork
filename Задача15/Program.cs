// на вхо цифра обозначающая день недели, 
// выход является ли этот день выходным
Console.WriteLine("Введите день недели в соответствии:");
Console.WriteLine("1 -  понедельник");
Console.WriteLine("2 -  вторник");
Console.WriteLine("2 -  среда");
Console.WriteLine("4 -  четверг");
Console.WriteLine("5 -  пятница");
Console.WriteLine("6 -  суббота");
Console.WriteLine("7 -  воскресенье");
int a;
int.TryParse(Console.ReadLine(), out a);
if (a == 6 || a == 7)
{
   Console.WriteLine("Выходной день"); 
}
else
{
       Console.WriteLine("Рабочий день");
}