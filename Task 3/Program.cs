//Задача 3: * Найдите сумму произведений пар чисел в одномерном целочисленном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Если кол-во элементов нечетное, то элемент посередине не учитывать.
//Результат сложения вывести на экран.

Console.Write("Введите количество чисел в массиве: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array = new int[N];
Random rnd = new Random();
int sum = 0;

for (int i = 0; i < N; i++) 
{
    array[i] = rnd.Next(7);
}
for (int i = 0; i < N / 2; i++) 
{
    sum += array[i] * array[N - (i + 1)];
}
Console.WriteLine($"[{String.Join(", ",array)}] -> {sum}");