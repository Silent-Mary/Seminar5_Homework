/* creates a copy of an array via copying each element
not sure why on earth this could be useful but here we go */ 
Console.Clear();

int[] GetRandomArray(int arrayLength, int start, int end)
{
    int[] array = new int[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = new Random().Next(start, end);
    }
    return array;
}

void PrintArray(int [] arrayToPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i < arrayToPrint.Length - 1)
        {
            Console.Write (", ");
        }
    }
    Console.Write("] ");
}

System.Console.WriteLine("Enter array length, min n & max n for range: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] CopyArray(int[] array)
{
    int[] arrayLength = new int [array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayLength[i] = array[i];
    }
    return arrayLength;
}

int[] userArray = GetRandomArray(arrayL, min, max); 
Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(userArray);
int[] CopiedArray = CopyArray(userArray);
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine();
PrintArray(CopiedArray);
Console.ForegroundColor = ConsoleColor.White;