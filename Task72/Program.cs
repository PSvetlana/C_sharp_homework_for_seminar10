/*
Задача 72: Заданы 2 массива: info и data. В массиве info хранятся двоичные представления
нескольких чисел (без разделителя). В массиве data хранится информация о количестве бит,
которые занимают числа из массива info. Напишите программу, которая составит массив
десятичных представлений чисел массива data с учётом информации из массива info.

входные данные:
data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
info = {2, 3, 3, 1 }
выходные данные:
1, 7, 0, 1
-----------------------------------
01 -> 1
111 -> 7
000 -> 0
1 -> 1
*/

void PrintArray(int[] arrayToPrint)
{
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        Console.Write(arrayToPrint[i]);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine();
}

int[] ToMakeArrayFromDecimalNumbers(int[] data, int[] info)
{
    int[] arrayDecimalNumbers = new int[info.Length];
    int count = 0;
    for (int i = 0; i < info.Length; i++)
    {
        while (info[i] - 1 >= 0 && count < data.Length)
        {
            arrayDecimalNumbers[i] += data[count] * (int)Math.Pow(2, info[i] - 1);
            info[i]--;
            count++;
        }
    }
    return arrayDecimalNumbers;
}

int[] data = { 0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = { 2, 3, 3, 1 };
int[] decimalArray = ToMakeArrayFromDecimalNumbers(data, info);
PrintArray(decimalArray);
