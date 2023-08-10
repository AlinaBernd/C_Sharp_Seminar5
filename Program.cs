// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
    {
        int num = new Random().Next(minValue, maxValue + 1);
        while (num < 100 || num > 999) 
        {
        num = new Random().Next(minValue, maxValue + 1);
        }
    array[i] = num;
    }
      return array;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfOddNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) 
            sum ++;

    return sum;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value greater than 100: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value less than 1000: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.WriteLine(SumOfOddNumbers(myArray));

*/
// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}
void WriteArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int SumOfOddNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i+= 2)
            sum += array[i];

    return sum;
}

Console.Write("Input a length of array: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int b = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(m, a, b);
WriteArray(myArray);
Console.WriteLine(SumOfOddNumbers(myArray));


// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
// Решение со случайным вводом

double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble();
        array[i] = Math.Round(array[i], 2);
    }
    return array;
}
void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

double MinusMinMax(double[] array)
{
    double max = array[0];
    double min = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > max) 
                max = array[i];
            
            if (array[i] < min) 
                min = array[i];
        }

        double res = max - min;
        return res;
}
Console.Write("Input a length of array: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(size);
WriteArray(myArray);
Console.WriteLine(MinusMinMax(myArray));

// Решение с вводом пользователя
double[] CreateRandomArray(int size)
{
    double[] array = new double[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input the {i} element array: ");
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
    return array;
}

void WriteArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

double MinusMinMax(double[] array)
{
    double res = 0;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (max < array[i]) max = array[i];
        else if (min > array[i]) min = array[i];
    }
    res = max - min;
    return res;
}

Console.Write("Inpun a length of array: ");
int length = Convert.ToInt32(Console.ReadLine());
double[] myArray = CreateRandomArray(length);
WriteArray(myArray);
Console.WriteLine(MinusMinMax(myArray));
