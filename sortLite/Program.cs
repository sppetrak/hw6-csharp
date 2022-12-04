int [] array  = {3, 5, 8, 9, 5, 7 ,1, 3, 6, 2};

void PrintArray(int[] array)
{
    int count = array.Length;
for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
}
Console.WriteLine();
}
PrintArray(array);
Array.Sort(array);

PrintArray(array);
