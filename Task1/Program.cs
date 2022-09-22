//Задача 1: Программа запрашивает натуральное число M, пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

Console.Write("Введите числа через запятую: ");
int[] a = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
 
for (int i = 0; i < a.Length; i++)
{
    if (a[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine($"Количество введенных элементов больше нуля: {count}");