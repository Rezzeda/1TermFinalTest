using System;
using static System.Console;

Clear();
Write("Введите элементы массива через пробел: ");
string[] elements = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

//WriteLine($"[{String.Join(", ", elements)}]");

WriteLine($"[{String.Join(", ", MaxThreeSymbolArray(elements))}]");

string[] MaxThreeSymbolArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count += 1;
        }
    }

    string[] array1 = new string[count];
    int j = 0;
    foreach (var item in array)
    {
        if (item.Length <= 3)
        {
            array1[j] = item;
            j++;
        }
    }
    return array1;
}
 


