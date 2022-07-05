// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//[1,0,1,1,0,1,0,0]

int[] GetRandomarray()
{
    int[] array = new int[8];
    for (int i = 0; i < 8; i++)
    {
        array[i] = new Random().Next(0,2);

    }
    return array;
}

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

int[] massive = new int [8];
massive = GetRandomarray();
Printarray(massive);

//Console.WriteLine(string.Join(",", array));
