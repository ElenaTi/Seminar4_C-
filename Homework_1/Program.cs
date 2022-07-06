/* Написать цикл, который принимает два числа (A и B) 
и возводит число A в натуральную степень  B. 
3, 5 -> 243
2,4 -> 16 */

int GetDegreeOfTwoNumbers(int number1, int number2)
{
    int degree = 1;
    for (int i = 1; i <= number2; i++)
    {
        degree = degree * number1;
    }
    return degree;
}

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int power = GetDegreeOfTwoNumbers(num1, num2);
Console.WriteLine($"Число {num1} в степени {num2} равно {power}.");