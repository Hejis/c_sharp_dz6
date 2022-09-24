// Задача 1: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Prompt(string message)
{
    Console.Write(message);
    string strValue = Console.ReadLine() ?? "0";
    bool isNumber = int.TryParse(strValue, out int value);
    if (isNumber)
    {
        return value;
    }
    throw new Exception("Данное значение невозможно преобразовать в число");
}

int[] GenerateArray(int length)
{
    int[] newArray = new int[length];
    for (int i = 0; i < newArray.Length; i++)
    {
        newArray[i] = new Random().Next(-10, 10);
    }
    return newArray;
}

void PrintArray(int[] array)
{
    foreach (int item in array)
    {
        System.Console.Write($"{item}\t");
    }
    System.Console.WriteLine();
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
    return count;
}


int Length = Prompt("Введите количество элементов ");
int[] array = GenerateArray(length: Length);
PrintArray(array);
int count = CountPositiveNumbers(array);
System.Console.WriteLine($"Количество элементов больше нуля = {count}");