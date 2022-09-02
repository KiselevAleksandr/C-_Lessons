Console.Write ("Введите число a: " );
int a = Convert.ToInt32(Console.ReadLine());
Console.Write ("Введите число b: " );
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (a > b)
{
    max = a;
    Console.WriteLine ("Максимальное число = "+max);
}
else
{
    max = b;
    Console.WriteLine ("Максимальное число = "+max);
}