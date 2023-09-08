/* Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3 */

Console.Clear();

int Prompt(string message)
{
    System.Console.Write(message); 
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value); 
    return result;
}

int[] InputArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt($"Enter element number {i + 1}: ");
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.Write("[ ");

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }

    Console.Write("]");
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int howlong = Prompt("Enter the number of elements: ");
int[] userArray; 
userArray = InputArray(howlong);
PrintArray(userArray);
Console.WriteLine();
Console.WriteLine($"N of positive digits = {CountPositiveNumbers(userArray)}");
