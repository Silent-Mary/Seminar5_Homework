/* Turns a denary number into binary one */ 
Console.Clear();
Console.WriteLine("Enter a denary number: ");
int denary = Convert.ToInt32(Console.ReadLine());

string Division(int denary)
{
    string result = string.Empty;
    int temp = 0;
    for (int i = denary; i > 0; i /= 2)
    {
        temp = i % 2;
        result = temp + result;
    }

return result;
}

string NoName = Division(denary);
Console.WriteLine(NoName);
