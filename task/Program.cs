// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();

string[] FillStringArray(string[] arrayForFilling)
{
    for (int i = 0; i < arrayForFilling.Length; i++)
    {
        Console.WriteLine($"Введите значение {i + 1}-го элемента:");
        arrayForFilling[i] = Console.ReadLine()!;
    }
    return arrayForFilling;
}

void PrintArray(string[] arrayPrint)
{
    Console.Write("[");
    for (int i = 0; i < arrayPrint.Length; i++)
    {
        if (i < arrayPrint.Length - 1)
        {
            Console.Write($"{arrayPrint[i]}, ");
        }
        else
        {
            Console.Write($"{arrayPrint[i]}");
        }
    }
    Console.WriteLine("]");
}

string[] CreateArrayWithShotStrings(string[] initArray, int lengthOfElements)
{
    int count = 0;
    for (int i = 0; i < initArray.Length; i++)
    {
        if (initArray[i].Length <= lengthOfElements)
        {
            count++;
        }
    }
 
    string[] newArray = new string[count];
    int result = 0;
    for (int j = 0; j < initArray.Length; j++)
    {
        if (initArray[j].Length <= lengthOfElements)
        {
            newArray[result] = initArray[j];
            result++;
        }
    }
    return newArray;
}

Console.WriteLine("Введите размер одномерного текстового массива:");
int size = Convert.ToInt32(Console.ReadLine()!);
string[] originalArray = new string[size];

originalArray = FillStringArray(originalArray);
Console.WriteLine("Изначальный массив:");
PrintArray(originalArray);

int lengthOfElements = 3;
string[] newArray = CreateArrayWithShotStrings(originalArray, lengthOfElements);
Console.WriteLine($"Новый массив с длинной элементов не более {lengthOfElements} символов:");
PrintArray(newArray);

