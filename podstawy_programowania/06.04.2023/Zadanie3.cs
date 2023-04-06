const uint n = 7;
uint[] t = new uint[n];
uint sumaP = 0;

Console.WriteLine("Ciag Fibonacciego:\n");
t[0] = 0;

if (n > 1)
{
    t[1] = 1;
}

for (int i = 2; i < n; i++)
{
    t[i] = t[i - 2] + t[i - 1];
    if (t[i] % 2 == 0)
    {
        sumaP += t[i];
    }
}
Console.WriteLine("Suma parzystych liczb wynosi: " + sumaP);
