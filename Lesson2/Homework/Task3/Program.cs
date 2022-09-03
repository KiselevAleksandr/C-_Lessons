Console.Write("Напишите цифру , обозначающую день недели (от 1 до 7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 5)
{
    Console.WriteLine("Это рабочий день! ");
}
else
{
    Console.WriteLine("Это выходной! ");
}
