Console.Write("Введите координату по оси оX точки А: ");
int xA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY точки А: ");
int yA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оZ точки А: ");
int zA = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оX точки B: ");
int xB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оY точки B: ");
int yB = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите координату по оси оZ точки B: ");
int zB = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow(xA-xB, 2) + Math.Pow(yA-yB, 2) + Math.Pow(zA-zB, 2));

Console.WriteLine($" Результат =  {Math.Round(distance,2)}");