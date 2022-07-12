int ReverNumber (int number)
{
    int reversedNumber = new int();
    while (number > 0)
    {
        reversedNumber = number % 10 + reversedNumber * 10;
       // Console.WriteLine(reversedNumber);       
        number /= 10;
    }
    return reversedNumber;
}

bool IsPolindrome (int number)
{
    bool isPalindrome = false;
    if (number != 0)
    {
        number = Math.Abs(number);
        int reversedNumber = ReverNumber(number);
        isPalindrome = (number == reversedNumber);
    }
    else
    {
        Console.WriteLine("Число не должно быть равно нулю");
    }
    return isPalindrome;
}
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
bool isPalindrome = IsPolindrome(userNumber);
if (isPalindrome)
{
    Console.WriteLine($"Число {userNumber} является палиндромом");
}
else
{
    Console.WriteLine($"Число {userNumber} не является палиндромом");
}
