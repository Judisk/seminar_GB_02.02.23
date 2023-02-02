
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

System.Console.WriteLine("Введите число N: ");

int numN = int.Parse(Console.ReadLine());

double SqrN=1;

while (SqrN<=numN)
{
    System.Console.Write(Math.Pow(SqrN,2)+" ");
    SqrN++;
}
