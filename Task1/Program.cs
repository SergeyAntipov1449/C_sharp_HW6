// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int[] ReadArray(string text)
{
    System.Console.WriteLine(text);
    int[] array = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
    return array;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(" | ", array) + "]");
}

int PosSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum++;
        }
    }
    return sum;
}
// |+|+|+|+|+|+||+|+|+|+|+|+|+|+|+|+|+|+|+|+|+|+|+|+||+|+|+|+|+|+|+|+|+|+|+|

int[] array = ReadArray("Введите числа через пробел:");
PrintArray(array);
System.Console.WriteLine(PosSum(array));
