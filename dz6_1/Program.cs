/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

int [] Array (int length, int start, int end)
    {
    Console.Write("Введите желаемое колиство чисел для подсчета - ");
    length = int.Parse(Console.ReadLine());
    int [] array = new int [length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите число {i}: ");
        array[i] = int.Parse(Console.ReadLine());                    
    }
        return array;            
    }
int NumberOfPositiv (int [] array)
    {
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
        return count;
    }
void PrintArray(int [] array)
    {
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i < array.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
    }
int [] newArray = Array( 5,5,5);
PrintArray(newArray);
int countNumber = NumberOfPositiv(newArray);
Console.WriteLine ($"Введено {countNumber} числа(ел) больше нуля");
