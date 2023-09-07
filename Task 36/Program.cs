/* Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */ 


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

int SumOfOddIndexes(int[] array)
{
    int count = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        count += array[i];
    }
    return count;
}

int[] userArray = GetRandomArray(arrayL, min, max);
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine($"sum of the odd positions is {SumOfOddIndexes(userArray)}");
