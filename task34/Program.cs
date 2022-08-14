/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
System.Console.WriteLine("Введите размер массива ");
int size = int.Parse(Console.ReadLine());
int count = 0;

int[] array = GetArray(size);
PrintArray(array);

for (int i = 0; i < array.Length; i++)
{
    if(array[i]% 2 == 0) count++;
    
}
System.Console.WriteLine(count);




int[] GetArray(int n)
{
    int[] arr = new int[n];
    Random rnd = new Random();

    for (int i = 0; i < n; i++)
    {
        arr[i] = rnd.Next(100, 1000);
    }
    return arr;
}


void PrintArray(int[] array)
{
    System.Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine(" ]");
    System.Console.WriteLine();
}


