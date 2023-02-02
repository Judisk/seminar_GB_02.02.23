
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

System.Console.WriteLine("Введите четверть");

int chet = int.Parse(Console.ReadLine());

if (chet==1)
{
    System.Console.WriteLine("x>0 y>0");
}
else if (chet==2)
{
    System.Console.WriteLine("x<0 y>0");
}
else if (chet==3)
{
    System.Console.WriteLine("x<0 y<0");
}
else if (chet==4)
{
    System.Console.WriteLine("x>0 y<0");
}
else if (chet==0)
{
    System.Console.WriteLine("x=0 y=0");
}
else 
{
    System.Console.WriteLine("Wrong number");
}
