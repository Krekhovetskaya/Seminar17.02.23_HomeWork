//Задача 23: Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. * при N < 0, нужно вывести от N до -1

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()); //ввод переменной
int i = 1; // начальное значение для цикла
int m = N; // m = -10
if (N < 0)
{
    i = N; //i = -10
    m = -N;// m = 10
    N = -1; // N = -1
    

}
int[] result = new int[m]; //массив на m элементов
for (int j = 0; i <= N; i++)
{
    result[j] = i * i * i;
    j++;
}
for (int j = 0; j < m; j++)
{
    Console.Write($"{result[j]} ");
}