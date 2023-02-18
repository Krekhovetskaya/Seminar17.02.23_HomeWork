// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
//  в которой находится эта точка.


Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine());

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());

if(X>0&&Y>0){
    Console.WriteLine("1");
}else if(X<0&&Y>0){
    Console.WriteLine("2");
}else if(X<0&&Y<0){
    Console.WriteLine("3");
} else if(X>0&&Y<0){
    Console.WriteLine("4");
} else if (X == 0 || Y == 0)
    Console.WriteLine("На оси");


// **Задача 18:**

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.Clear();
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());

switch (quarter)
{
    case 1:
        {
            Console.WriteLine("x>0 y>0");
            break;
        }
    case 2:
        {
            Console.WriteLine("x<0 y>0");
            break;
        }
    case 3:
        {
            Console.WriteLine("x<0 y<0");
            break;
        }
    case 4:
        {
            Console.WriteLine("x>0 y<0");
            break;
        }
    default:
        {
            Console.WriteLine("Введена неправильная четверть");
            break;
        }
}
// Напишите программу, 
// которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09
//double s = Math.Sqrt(...);

Console.Clear();
Console.Write("Введите X1: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
double y2 = double.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));

Console.WriteLine($"d={d:f3}");

// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел от 1 до N.

// 5 -> 1, 4, 9, 16, 25.

// 2 -> 1,4
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int i = 1;
int m = N; // m = -10
if (N < 0)
{
    i = N; //i = -10
    m = -N;// m = 10
    N = -1; // N = -1
    

}
int[] result = new int[m];
for (int j = 0; i <= N; i++)
{
    result[j] = i * i;
    j++;
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}
