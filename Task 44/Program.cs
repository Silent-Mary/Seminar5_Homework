/* No recursion: enter first N Fibonacci digits. 
5 - 0 1 1 2 3 
3 - 0 1 1
7 - 0 1 1 2 3 5 8 */ 
Console.Clear();
Console.WriteLine("Enter N of digits: ");
int quantity = Convert.ToInt32(Console.ReadLine());
int[] Qarray = new int [quantity];

void Fibonacci(int[] array)
{
    array[0] = 0;
    array[1] = 1;
    Console.Write("Fibonacci sequence of N numbers: 0 1 ");
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i-1] + array[i-2];
        Console.Write($"{array[i]} ");
    }
}

Fibonacci(Qarray);




