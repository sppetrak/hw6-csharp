// Задача 43: Написать программу, которая на вход принимает массив из любого 
// количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).

Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
int[] array = FillArray(size);
PrintArray(array);

int[] FillArray(int size,int  minVal = 0,int  maxVal = 100)
{
    int[] array =new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(0,100);
    }
    return array;
}


void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}


void SortedArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[i])
            {
                minPosition = j;
                int temp = array[i];
                array[i] = array[minPosition];
                array[minPosition] = temp;
            }
        }

    }
}
SortedArray(array);

PrintArray(array);