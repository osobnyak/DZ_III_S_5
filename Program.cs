// Задача 34. Задайте массив заполненный случайными 3-х значными числами. Сколько чётных чисел в массиве.
//v.0.1.my

int[] num = new int[10];
int res = 0;

for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(100, 1000);
    Console.Write($"{num[i]} ");
    if (num[i]%2==0)
    {
        res++;
    }
}
Console.WriteLine();
Console.WriteLine(res);





//v.0.2.group