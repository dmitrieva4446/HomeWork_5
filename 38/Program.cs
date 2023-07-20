// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void InputArray(double[] array)
{
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
        array[i] = Math.Round(100 * rnd.NextDouble(), 2);
}

double DifOfArrayElements(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i])
            max = array[i];
        if (min > array[i])
            min = array[i];

    }
    return max-min;
}

Console.Clear();
Console.Write("Введите кол-во элементов в массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
double[] array = new double[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
Console.WriteLine(Math.Round(DifOfArrayElements(array),2));

