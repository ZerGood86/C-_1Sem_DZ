//Задача 6: Напишите программу, которая на вход принимает
// число и выдаёт, является ли число чётным.
Console.Clear();

Console.WriteLine("Enter number");
int number = int.Parse(Console.ReadLine()!);

int x = number % 2;
if(x == 0)
{
    Console.WriteLine("yes");
}
else
{
    Console.WriteLine("no");
}
