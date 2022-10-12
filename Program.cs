
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



// Console.Clear();
// Console.WriteLine("Enter the required number of digits ");
// int i = Convert.ToInt32(Console.ReadLine());

// int [] array = new int[i];
// for (i = 0; i < array.Length; i++)
// {
//     Console.WriteLine("Enter number: ");
//     array[i] = Convert.ToInt32(Console.ReadLine());
// }
// void PrintArray(int[] marray)
// {
//     int count = marray.Length;
//     int position = 0;  
//     Console.Write("[ ");
//     while (position < count - 10)
//     {
//         Console.Write($"{marray[position]}, ");
//         position++;
//     }
//     Console.Write($"{marray[position]}]");
// }

// Console.WriteLine("Entered numbers");
// PrintArray(array);

// int count = 0;
// for (i = 0; i < array.Length; i++)
// {
//     if (array[i] > 0)
//     count++;
// }
// Console.WriteLine ();
// Console.WriteLine ($"Numbers greater than 0: {count}");




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("enter a value b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a number k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a value b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("enter a number k2");
double k2 = Convert.ToInt32(Console.ReadLine());

double x = (-b2 + b1)/(-k1 + k2);
double y = k2 * x + b2;

Console.WriteLine($"the lines will intersect at the point: {x}, Y: {y}");