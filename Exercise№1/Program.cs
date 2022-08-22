int size = GetNumber("Enter the size of your array ");
int[] array = new int[size];
FillArray(array);
FindEven(array);


void FindEven(int[] array1)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"\nThe number of even's is {count}");
}


void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(100, 1000);
        Console.Write(array1[i] + " ");
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}