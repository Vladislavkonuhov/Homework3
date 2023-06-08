Console.Clear();
Console.Write("Введите количество элементов массива: ");
int a = int.Parse(Console.ReadLine()!);
int[] randomArray = new int[a];

void mas(int a)
{
    Console.Write("[ ");
for (int i = 0; i < a; i++)
{
randomArray[i] = new Random().Next(1,9);
Console.Write(randomArray[i] + ", ");
}
    Console.Write("]");
    Console.WriteLine();
}

int kol(int[] randomArray)
{
int sum = 0;
int i = 1;
while (i < randomArray.Length)
{
sum = sum + randomArray[i];
i = i + 2;
}
return sum;
}

mas(a);
Console.WriteLine($"\nCумма элементов, стоящих на нечётных позициях: {kol(randomArray)}");