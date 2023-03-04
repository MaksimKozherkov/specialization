/*
Написать программу, которая из имеющегося массива строк формирует массив из строк длина которых
меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
выполнения алгоритма. При решении, не рекомендуется пользоваться коллекциями, лучше обойтись
исключительно массивами.
Примеры:
1) ["Hello", "2", "world", ":-)"] -> ["2", ":-)"]
2) ["1234", "1567", "-2", "computer science"] -> ["-2"]
3) ["Russia", "Denmark", "Kazan"] -> []
*/

using static System.Console;

Clear();

WriteLine("Программа сформирует массив из строк, длина которых, меньше либо равна 3 символам из имеющегося массива.");
WriteLine();
Write("Введите количество элементов в заданном массиве: ");
bool isSize = int.TryParse(ReadLine()!, out int size);
if (!isSize)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}
Write("Введите количество символов элемента в новом массиве: ");
bool isARRLength = int.TryParse(ReadLine()!, out int ARRLength);
if (!isARRLength)
{
    WriteLine("Ошибка! Вы ввели не число!");
    return;
}
WriteLine();
WriteLine("Введите поочерёдно элементы задаваемого массива, через Enter:");
string[] array = GetArray(size);
WriteLine();
WriteLine("Полученный массив:");
WriteLine("[{0}]", string.Join(", ", array));

















string[] GetArray(int size)         // метод задающий массив
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Write($"{i + 1} -> ");
        arr[i] = ReadLine()!;
    }
    return arr;
}