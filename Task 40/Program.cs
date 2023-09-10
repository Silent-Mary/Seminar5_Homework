/* Gets 3 numbers and checks if there may exist a triangle with such length sides */ 
Console.Clear();
Console.Write("Enter 3 lengths: ");
// int a = Convert.ToInt32(Console.ReadLine());

int[] FillSidesArray()
{
    int[] array = new int[3];
    for (int i = 0; i < 3; i++)
    {
        array [i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

bool MaybeTriangle(int[] array)
{
    if (array[0] < array[1] + array[2]
    && array[1] < array[0] + array[2]
    && array[2] < array[0] + array[1])
    {
        return true;
    }
    else
    {
        return false;
    }
}

int[] userArray = FillSidesArray();
bool result = MaybeTriangle(userArray);
Console.WriteLine(result);