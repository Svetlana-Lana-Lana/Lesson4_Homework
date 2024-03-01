//Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)

int[] array = { 10, 2, 35, 4, 5, 8, 3};
int[] ArrayInReversOrder(int[] array)
{
    int temp = 0;
    for (int i = 0; i < array.Length / 2; i++)
    {
        temp = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
    return array;
}

int [] new_array = ArrayInReversOrder(array);

void ShowArray(int[] new_array)
{
    foreach (int item in new_array)
    {
        Console.Write(item + " ");
    }
}

ShowArray(new_array);





