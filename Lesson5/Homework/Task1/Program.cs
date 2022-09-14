int[] array = new int [10];
int arraySize = array.Length;
int countEvenNumber = 0;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(100,1000);
    if (array[i]%2 == 0)
    {
        countEvenNumber++;
    }
}
Console.WriteLine("Array: [ " +  String.Join(" ; " , array) + " ]  Количество четных чисел в массиве = " + countEvenNumber);