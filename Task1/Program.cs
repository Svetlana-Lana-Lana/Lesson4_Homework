// Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа 'q'или при вводе числа, сумма цифр которого четная.
Console.Clear();

bool GetSumOfElementsNumberAndCheckForParity(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    if (sum % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
//bool answer = GetSumOfElementsNumberAndCheck(4539);
//Console.WriteLine(answer);

while (true)
{
    Console.WriteLine("Введите число: ");
    string input = Console.ReadLine();
    int num = 0;
    if (input == "q")
    {
        Console.WriteLine("Stop");
        break;
    }
    else if (int.TryParse(input, out num))
    {
        num = Convert.ToInt32(input);
        if (GetSumOfElementsNumberAndCheckForParity(num))
        {
            Console.WriteLine("Stop");
            break;
        }
    }
    Console.WriteLine("Длязавершения программы введите число или 'q'.");

}
