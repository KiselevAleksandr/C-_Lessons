Console.WriteLine("Введите массив чисел через пробел: ");
    string input = Console.ReadLine();
    string[] elements = input.Split(" ");
    int[] array = new int[elements.Length];

    for (int i = 0; i < elements.Length; i++)
    {
        array[i] = Convert.ToInt32(elements[i]);
    }

    Console.WriteLine("");
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }

    Console.WriteLine(array[array.Length - 1] + "]");

