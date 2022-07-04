// Принимает число и говорит,сколько цифр в числе
int GetNumberOfNumber (int number1)
{
    int count = 0;
    while (number1 > 0)
    {
        number1 = number1 / 10; 
        count ++;
    }
    return count;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetNumberOfNumber(number);
Console.WriteLine(result);

