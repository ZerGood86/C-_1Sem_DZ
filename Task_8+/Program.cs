//Задача 8: Напишите программу, которая на вход принимает 
//число (N), а на выходе показывает все чётные числа 
//от 1 до N.

Console.Clear();

Console.WriteLine("Enter N");
int N = int.Parse(Console.ReadLine());

if(N > 1)
{
    int x = N / 2;
    int count = 0;
    if(count < x)
    {
        int E = (count + 1) * 2;
        Console.Write(E + " ");
        count = count + 1;
    }
}
else
{
   Console.WriteLine("\nError");
}