int[] array = new int [10];
int arraySize = array.Length;
int unevenPositionSum = 0;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(0,1000);

    if (i % 2 != 0)
    {
        unevenPositionSum += array[i];
    }
}

Console.WriteLine("Array: [ " +  String.Join(" ; " , array) + " ]  Сумма элементов на нечётныx позициях = " + unevenPositionSum );
