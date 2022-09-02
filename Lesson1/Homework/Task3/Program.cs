Console.Write ("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

if (x % 2 == 1)
{
    Console.WriteLine("Число " + x + " является: Нечетным");
}
else
{
    Console.WriteLine("Число " + x + " является: Четным");
}