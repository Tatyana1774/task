/*Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
Первоначальный массив можно ввести c клавиатуры, либо задать на старте выполнения алгоритма. 
При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами. */
Console.WriteLine("Hello, World!");
string[] array = AskArray();
string[] result = FindLessThan(array, 3);
Console.WriteLine($"[{string.Join(", ", array)}] -> [{string.Join(", ", result)}]");

string[] FindLessThan(string[] input, int number)
{
    string[] output = new string[CountLessThan(input, number)];

    for (int i = 0, j = 0; i < input.Length; i++)
    {
        if (input[i].Length <= number)
        {
            output[j] = input[i];
            j++;
        }
    }

    return output;
}

int CountLessThan(string[] input, int number)

{
    int count = 0;

    for (int i = 0; i < input.Length; i++)
    {
        if (input[i].Length <= number)
        {
            count++;
        }
    }

    return count;
}

string[] AskArray()
{
    Console.Write("Введите значения через пробел: ");
    return Console.ReadLine().Split(" ");
}