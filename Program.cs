using System;

class Program
{
    static void Main(string[] args)
    {
        // Ввод массива строк с клавиатуры
        Console.WriteLine("Введите элементы массива (через запятую):");
        string[] input = Console.ReadLine().Split(',');

        // Формирование нового массива из строк, длина которых меньше или равна 3 символам
        string[] output = GetStrings(input);

        // Вывод нового массива
        Console.WriteLine("Результат:");
        for (int i = 0; i < output.Length; i++)
        {
            Console.WriteLine(output[i]);
        }

    }

    static string[] GetStrings(string[] input)
