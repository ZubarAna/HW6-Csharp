/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
/*
Console.Write("Введите количество чисел: ");
int n = Convert.ToInt32(Console.ReadLine());
int [] array = new int [n];
for(int i = 0; i < array.Length; i++)
{
    Console.Write("Введите " + (i + 1) + "-е число: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine(string.Join(",", array));

int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
 
Console.WriteLine("Количество элементов > 0: " + count);
*/

/* адача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*
Console.Write("Введите b1: ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = Convert.ToInt32(Console.ReadLine());

if(k1 == k2 && b1 == b2)
Console.WriteLine("Прямые совпадают");
else
if(k1 == k2)
Console.WriteLine("Прямые параллельны");
else
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    Console.WriteLine("(" + string.Join(",", x, y) + ")");
}
*/

/* Задана целочисленная квадратная матрица размером N x N. 
Требуется транспонировать ее относительно побочной диагонали.

Входные данные

Первая строка входного файла INPUT.TXT содержит натуральное число N – количество строк и столбцов матрицы.
В каждой из последующих N строк записаны N целых чисел – элементы матрицы. 
Все числа во входных данных не превышают 100 по абсолютной величине.

Выходные данные

В выходной файл OUTPUT.TXT выведите матрицу, полученную транспонированием исходной матрицы относительно
побочной диагонали.

Пример

№	INPUT.TXT	OUTPUT.TXT
	5
    3 4 9 6 2   0 8 7 1 2
    8 2 0 5 1   7 3 8 5 6 
    4 7 4 8 7   3 3 4 0 9
    7 1 3 3 8   6 1 7 2 4
    5 6 3 7 0   5 7 4 8 3	
*/
/*
Console.Write("Введите кол-во строк и столбцов квадратной матрицы nxn: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, n];
void PrintArray(int[,] matrix)
{                               
for (int i = 0; i <  matrix.GetLength(0); i++)
{
       for (int j = 0; j < matrix.GetLength(1); j++)
       {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
}
}
void TransArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int temp = matrix[i, j];
            matrix[i, j] = matrix[matrix.GetLength(0) - 1 - j, matrix.GetLength(1) - 1 - i];
            matrix[matrix.GetLength(0) - 1 - j, matrix.GetLength(1) - 1 - i] = temp;
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    
}

PrintArray(matrix);
Console.WriteLine();
TransArray(matrix);
*/
// Что-то тут не получилось, когда я дохожу до первого элемента второй строки, мой алгоритм 
// просто приравнивает ко второму элементу первой строки, а там я уже поменяла и получается,
// что у меня просто верхний треугольник зеркалит нижний треугольник.