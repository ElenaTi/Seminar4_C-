/* программа, которая задает массив из 8 элементов и выводит их на экран
1, 2, 5, 7, 19 - > [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33] */

void Printarray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
       if (i == 0)
       {
          Console.Write($"[{array1[i]}, ");
       }
       else if (i == array1.Length - 1)
       {
            Console.Write($"{array1[i]}]");
       }
       else
       {
        Console.Write($"{array1[i]}, ");
       }
       
    }
}

Console.WriteLine("Введите количество элементов массива: ");
int elementCount = Convert.ToInt32(Console.ReadLine());

int[] massive = new int [elementCount];
for (int i = 0; i < massive.Length; i++)
{
    Console.Write($"Введите элемент массива под индексом {i}: ");
    massive[i] = Convert.ToInt32(Console.ReadLine());
}

Printarray(massive);

