// Задача 36. Создаём массив с рандомными числами. Найти сумму элементов стоящих на нечётных позициях.
//v.0.1.my

int[] num = new int[10];
int res = 0;
int i = 0;

for (i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(0, 2);
    Console.Write($"{num[i]} ");
}
Console.WriteLine();

i = 0;
while (i < num.Length)
{
    res = res + num[i];
    i = i + 2;
}
Console.Write("сумма нечётных позиций = ");
Console.WriteLine(res);










//v.0.2.group 


//*********************************************************************