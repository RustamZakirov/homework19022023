// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 21); // [1, 20]
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            Console.Write($"{matrix[i, j]} \t");
        Console.WriteLine();
    }
}

void findsumm(int[,] matrix)
{
    int[] summ = new int[matrix.GetLength(0)];
    int k = matrix.GetLength(0);
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
            temp = temp + matrix[i, j];
        summ[i] = temp;
        Console.WriteLine($"Сумма строки {i + 1} = {summ[i]}");
    }
    int count = 0;
    for (int a = 0; a < summ.Length -1; a++)
        {
            if (summ[count] > summ[a + 1])
                count = a + 1;
        }
    Console.WriteLine($"Минимальная строка: {count + 1}");
}

Console.Clear();
Console.Write("Введите размер массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
if (size[0] != size[1])
    Console.WriteLine("Матрица должна быть прямоугольной");
else
{
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine();
findsumm(matrix);
}
