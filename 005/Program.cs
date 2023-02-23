// Вывести первые N строк треугольника Паскаля. Сделать вывод в виде равнобедренного треугольника

int FindCount(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
return x;
}

Console.WriteLine("Количество строк N:");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Треугольник Паскаля");
for (int i = 0; i < n; i++)
{
    for (int c = 0; c <= (n - i); c++)
    {
        Console.Write(" "); 
    }
    for (int c = 0; c <= i; c++)
    {
        Console.Write(" ");
        Console.Write(FindCount(i) / (FindCount(c) * FindCount(i - c)));
    }
    Console.WriteLine();
    Console.WriteLine();
}
