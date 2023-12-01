Console.Write("введите количество элементов массива: ");
int a = Convert.ToInt32(Console.ReadLine());

double[] randomArray = new double[a];
void mas(int a)
{
    Random rand = new Random();
    for(int i = 0; i < a; i++)
    {
        randomArray[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble());
        Console.Write($"{randomArray[i]:F2}");
    }

}

double raz(double[] randomArray)
{
    double min = randomArray[0];
    double max = randomArray[0];
    int i = 1;
    while (i < randomArray.Length)
    {
        if (max < randomArray[i])
        max = randomArray[i];
        if(min > randomArray[i])
        min = randomArray[i];
        i = i + 1;
    }
return max-min;
}
Console.Write($"\n Разница между максимальным и минимальным элементом массива: {raz(randomArray):F2}");