Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int revers_number = 0;
int rem = 0;
int i = number;

while (i > 0)
{
    rem = i % 10;
    revers_number = revers_number * 10 + rem;
    i /= 10 ;
}    
if (number == revers_number)
{
    Console.WriteLine("Число " + number + " является палиндромом;");
}
else Console.WriteLine("Число " + number + " не является палиндромом;");

