Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = 0;
while (number > 100)
{
    number /= 10;
    result = number % 10;
}
Console.Write("Вторая цифра числа: " + result);
