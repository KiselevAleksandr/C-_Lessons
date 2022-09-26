Console.WriteLine("Введите размер массива m*n ");
int m = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

double[,] array = new double[m, n];

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = Convert.ToDouble(new Random().Next(-10, 10)) / 10;
        array[i, j] = Math.Round(new Random().NextDouble(), 2);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine("");
}
