// Задача 43: Написать программу, которая на вход принимает массив из любого 
// количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, 
// но отсортированный по возрастанию(от меньшего числа к большему).


int[] array = {6, 3, 9, 8, 1, 5, 6, 2, 4, 7};

PrintArray(array);

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
            if (array[j] < array[j]) minPosition = j;
            {
                minPosition = j;
            }
        }
        int temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }
}
SortedArray(array);

PrintArray(array);