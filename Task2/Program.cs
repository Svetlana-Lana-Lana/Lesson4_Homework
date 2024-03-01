//Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}


void ShowArray(int [] array)
{
    foreach (int item in array)
    {
        Console.Write(item + " ");
    }
}

int CountEvenElements(int [] array)
{
    int sum = 0;
    foreach(int item in array)
    {
        if(item % 2 == 0)
        {
            sum++;
        }
    }
    return sum;
}

int [] array = CreateRandomArray(100, 1000, 10);
ShowArray(array);
int sum = CountEvenElements(array);
Console.Write(sum);













