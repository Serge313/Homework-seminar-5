int size = GetNumber("Enter the size of your array ");
int[] array = new int[size];
FillArray(array);
DifferenceMinMax(array);


void DifferenceMinMax(int[] array1)
{
    int min = array1[0];
    int max = array1[0];
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i] < min)
        {
            min = array1[i];
        }
        if (array1[i] > max)
        {
            max = array1[i];
        }
    }
    Console.Write($"\nmin = {min}, max = {max}, difference = {(max - min)}");
}


void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(1, 21);
        Console.Write(array1[i] + " ");
    }
}


int GetNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}