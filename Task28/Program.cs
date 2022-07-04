//Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int multiplicationNumbers (int num1, int num2)
{
    int multiply = 1;
    for (int i = num1; i <= num2; i++)
    {
        multiply = i * multiply ;
    }
    return multiply;
}
int number1 = 1;
Console.WriteLine("Введите число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int multi = multiplicationNumbers(number1, number2);
Console.WriteLine($"{number2} -> {multi}");
