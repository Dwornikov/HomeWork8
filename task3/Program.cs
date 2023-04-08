void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
            matrix[i, j] = new Random().Next(1, 11);
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


int[,] Umnoj(int[,] First, int[,] Second)
{
    int[,] result = new int[First.GetLength(0), First.GetLength(1)];
    for (int i = 0; i < First.GetLength(0); i++)
    {
        for (int j = 0; j < First.GetLength(1); j++)
            result[i, j] = First[i, j] * Second[i, j];
    }
    return result;
}


Console.Clear();
Console.Write("Введите размер матриц: "); 
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] First = new int[size[0], size[1]];
int[,] Second = new int[size[0], size[1]];
InputMatrix(First);
InputMatrix(Second);
Console.WriteLine("Начальный массив 1: ");
PrintMatrix(First);
Console.WriteLine("Начальный массив 2: ");
PrintMatrix(Second);
Console.WriteLine("Результат:");
PrintMatrix(Umnoj(First, Second));