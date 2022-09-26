int[,] CreateMatrix(int m, int n)
{
    int[,] numbers = new int[m, n];

    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
    return numbers;
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine("Матрица: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

int[] SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
    return array;
}

int[,] numbers = CreateMatrix(3, 4);
PrintMatrix(numbers);

void SortMatrix(int[,] numbers)
{
    int[] row = new int[numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            row[j] = numbers[i, j];
        }
        row = SortArray(row);
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = row[j];
        }
    }
}
SortMatrix(numbers);
PrintMatrix(numbers);