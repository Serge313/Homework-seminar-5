int size = GetNumber("Enter the size of your array ");
int[] array = new int[size];
FillArray(array);
FindSum(array);


void FindSum(int[] array1)
{
    int sum = 0;
    for (int i = 1; i < array1.Length; i = i + 2)
    {
        sum += array1[i];
    }
    Console.WriteLine($"\nThe sum of numbers with an odd index is {sum}");
}


void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(1, 11);
        Console.Write(array1[i] + " ");
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}