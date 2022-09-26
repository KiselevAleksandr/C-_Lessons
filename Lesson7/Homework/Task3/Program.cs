int[,] numbers = new int[3, 3];
double[] average = new double[numbers.GetLength(1)];

Console.WriteLine("Задана матрица: ");
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        numbers[i, j] = new Random().Next(0, 10);
        Console.Write(numbers[i, j] + " ");
        average[j] += Convert.ToDouble(numbers[i, j]) / numbers.GetLength(0);
    }
    Console.WriteLine("");
}
Console.WriteLine("Среднее арифметическое столбца: ");
for (int j = 0; j < numbers.GetLength(1); j++)
{
    Console.Write(Math.Round(average[j], 1) + " ");
}