// Задача 29: Напишите программу, которая задаёт массив из 8 элементов
// и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
    int[] array = new int[size];
    var random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(0, 2); // last value is out of range: 0 - 1
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}

Console.WriteLine("Please enter array length: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] arr = CreateArray(size);
PrintArray(arr);

