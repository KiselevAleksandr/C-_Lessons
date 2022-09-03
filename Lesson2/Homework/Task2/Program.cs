Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result1 = 0 ;
int finishResult = 0;
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет ");
}
while(number > 1000)
{
    result1 = number / 10 ;
    number = result1;
}
if (result1 > 100)
{
    finishResult = result1 % 10;
    Console.WriteLine("Третья цифра числа: " + finishResult);
}

