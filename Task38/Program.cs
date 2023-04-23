// Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArrayRnd(int size, int min, int max)
{
double[] arr = new double[size];
Random rnd = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rnd.NextDouble() * (max - min) + min;
}
return arr;
}

void PrintArray(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        double round = Math.Round(arr[i], 1);
       if (i < arr.Length - 1) Console.Write($"{round}, ");
        else Console.Write($"{round}");
    }
}

double FindMax(double[] arr)
{
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] > max) max = arr[i];
    }
    return max;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] < min) min = arr[i];
    }
    return min;
}

double MaxMinusMin(double max, double min)
{
   double diff = max - min;
   return diff;
}

double[] array = CreateArrayRnd(5, -100, 100);
Console.Write("[");
PrintArray(array);
Console.Write("]");
Console.WriteLine();

double maximum = FindMax(array);
double minimum = FindMin(array);
double maxMinusMin = MaxMinusMin(maximum, minimum);
Console.WriteLine($"Max element {Math.Round(maximum, 1)} minus min {Math.Round(minimum, 1)} element is {Math.Round(maxMinusMin, 1)}");

