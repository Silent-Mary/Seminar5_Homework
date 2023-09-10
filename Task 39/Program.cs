/* Переворачиваем одномерный массив.
1) поменять числа местами в исходном массиве
2) либо создать новый и в него вписать перевертыша */
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

int[] ReverseArray(int[] arrayToReverse)
{
    int temp = 0;
    for (int i = 0; i < arrayToReverse.Length/2; i++)
    {
        temp = arrayToReverse[i];
        arrayToReverse[i] = arrayToReverse[arrayToReverse.Length - 1 - i];
        arrayToReverse[arrayToReverse.Length - 1 - i] = temp;
    }
    return arrayToReverse;
}

System.Console.WriteLine("Enter array length, min n & max n for range: ");
int arrayL = Convert.ToInt32(Console.ReadLine());
int min = Convert.ToInt32(Console.ReadLine());
int max = Convert.ToInt32(Console.ReadLine());

int[] userArray = GetRandomArray(arrayL, min, max); 
Console.ForegroundColor = ConsoleColor.Blue;
PrintArray(userArray);
int[] ReversedArray = ReverseArray(userArray);
Console.ForegroundColor = ConsoleColor.Green;
System.Console.WriteLine();
PrintArray(ReversedArray);
Console.ForegroundColor = ConsoleColor.White;
