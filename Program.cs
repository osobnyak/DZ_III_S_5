// Задайте массив вещественных чисел. Найдите разницу между max и min элементами массива.
//v.0.1.my

double[] num = new double[10];
double max = 0;
double min = 0;

for (int i = 0; i < num.Length; i++)
{
    num[i] = (new Random().NextDouble() + new Random().Next(-10, 11));
    Console.Write($"{Math.Round(num[i], 1)} ");
    if (num[i] > max)
    {
        max = Math.Round(num[i], 1);
    }
    if (num[i] < min)
    {
        min = Math.Round(num[i], 1);
    }
}
Console.WriteLine();
Console.Write("max = ");
Console.WriteLine(max);
Console.Write("min = ");
Console.WriteLine(min);











//v.0.2.group 


//*********************************************************************


