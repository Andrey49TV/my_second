int [] a = new int[10];
int count = 0;

for (int i = 0; i < 10; i++)
{
    Console.Write("a[{0}]=", i);
    a[i] = Convert.ToInt32(Console.ReadLine());
    if ((a[i] % 2) == 0)
    count++;
}
Console.WriteLine(count);
