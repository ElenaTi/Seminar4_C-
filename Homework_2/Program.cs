/* Принимаем на вход число, Выдает сумму цифр в числе
452 -> 11
82 -> 10
9012 -> 12 */

int GetSumOfNumber (int number1)
{
    int sum = 0;
    while (number1 > 0)
    {
        sum = sum + number1 % 10;
        number1 = number1 / 10; 
    }

    return sum;
}

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = GetSumOfNumber(number);
Console.WriteLine(result);