Console.Clear();

Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

if(a > b)
{
    Console.WriteLine("\n"+a);
}
if(a == b)
{
    Console.WriteLine("\nЧисла равны");
}
if(a < b)
{
    Console.WriteLine("\n"+b);
}
