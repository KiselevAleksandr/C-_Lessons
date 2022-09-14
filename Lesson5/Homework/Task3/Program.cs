int[] array = new int [10];
int arraySize = array.Length;
for (int i = 0; i < arraySize; i++)
{
    array[i] = new Random().Next(0,1000);
}
int min = array[0];
int max = array[0];
for (int i = 0; i < arraySize; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    else if (array[i]< min)
    {
        min = array[i];
    }
}

Console.WriteLine("Array: [ " +  String.Join(" ; " , array) + " ] max = " + max + " min= " + min + " Разница между max и min  =  " + (max -  min) );
