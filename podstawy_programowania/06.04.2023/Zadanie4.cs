const int m = 7;
int[] y = new int[m];

Console.WriteLine("Tablica Indexowana:\n");

y[0] = 0

for (int i = 1; i < m; i++)
{
    y[i] = i;
    if (y[i] % 2 == 0)
    {
        y[i] = i * i;
    }
    else
    {
        y[i] = i - 1;
    }
    Console.Write(", " + y[i]);
}
