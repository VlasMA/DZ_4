// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Вывод сделать отдельным методом.
int[] array = new int[8];

void  PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 35);
        Console.Write("{0} ", array[i]);
    }
}

PrintArray(array);

