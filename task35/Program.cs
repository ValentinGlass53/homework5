/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/
System.Console.WriteLine("Введите длинну массива");
int size = int.Parse(Console.ReadLine());
int sum = 0;

int[] array = GetArray(size);
PrintArray(array);

for (int i = 1; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        sum = sum + array[i];
        System.Console.WriteLine(array[i]);
    }
}
System.Console.WriteLine(sum);


int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(-100, 101);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}