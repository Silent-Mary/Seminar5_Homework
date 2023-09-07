/* Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76 */

Console.Clear();

double[] GetRandomArray(int arrayLength, double start, double end)
{
    double[] array = new double[arrayLength];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Math.Round((new Random().NextDouble() * (end - start) + start), 2);
    }
    return array;
}

void PrintArray(double [] arrayToPrint)
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
double min = Double.Parse(Console.ReadLine());
double max = Double.Parse(Console.ReadLine());

double GetMin(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

double GetMax(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double[] userArray = GetRandomArray(arrayL, min, max);
double minimal = GetMin(userArray);
double maximal = GetMax(userArray);
PrintArray(userArray);
System.Console.WriteLine();
System.Console.WriteLine($"The difference between max number {maximal} & min number {minimal} is {maximal - minimal}");