// Задача 41:
// 1. Пользователь вводит с клавиатуры M чисел.
// 2.Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3


Console.Write("Введите числа через запятую: ");
string numbers = Console.ReadLine();

string[] enternum = new string[numbers.Length];
int j = 0;

for (int i = 0; i < enternum.Length; i++)
{
    if (numbers[i] == ',')
    {
        j++;
    }
    else
    {
        enternum[j] = enternum[j] + $"{numbers[i]}";
    }
}
j++;


int[] resultNumbers = new int[j];

PrintArray(resultNumbers, enternum);
int sum = 0;
for (int i = 0; i < j; i++)
{
    if (resultNumbers[i] > 0)
    {
        sum++;
    }
}
Console.WriteLine($"Количество чисел больше 0 --> {sum}");

void PrintArray(int[] array, string[] strarray)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(strarray[i]);
        if (i < array.Length - 1)
            Console.Write($"{array[i]}, "); //выводим последний элемент без запятой в конце!!!!!
        else
            Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}
