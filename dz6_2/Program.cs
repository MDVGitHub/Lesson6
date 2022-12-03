/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/


int GetNumberFromUser(string message)
    {
    int result = 0;
    Console.WriteLine(message);
    result = Convert.ToInt32(Console.ReadLine());
    return result;
    }

double PointIntersection (double b1, double k1, double b2, double k2)
    {
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine($"Точка пересечения двух прямых ({x};{y})");
    return y;
    }
Console.WriteLine("Введите значения b1, k1, b2, k2 ");
int b1 = GetNumberFromUser ("Введите b1");
int k1 = GetNumberFromUser ("Введите k1");
int b2 = GetNumberFromUser ("Введите b2");
int k2 = GetNumberFromUser ("Введите k2");
double result = PointIntersection (b1, k1, b2, k2);