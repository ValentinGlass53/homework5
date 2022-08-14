/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/

System.Console.WriteLine("Введите длинну массива");
int size = int.Parse(Console.ReadLine());
int max = 0;

int[] array = GetArray(size);
PrintArray(array);



for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
}
System.Console.WriteLine("Максимальное число в массиве = " + max);


int min = max;


for (int i = 0; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
}

System.Console.WriteLine("Минимальное число в массиве = " + min);

int result = max - min;

System.Console.WriteLine("Разница между максимальным и минимальным числом = " + result);


int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    System.Console.Write("Массив -> [ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine(" ]");
}
