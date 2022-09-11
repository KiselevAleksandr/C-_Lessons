Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int rem = 0 ;
int sum = 0;
int i = number;

while (i != 0)
{
    rem = i % 10;
    sum += rem;
    i /= 10;
}

Console.Write("Сумма чисел в числе = " + sum);
