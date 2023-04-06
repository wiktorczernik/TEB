const uint n = 7;
uint[] t = new uint[n];

Console.WriteLine("Ciag Fibonacciego:\n");
t[0] = 0;
Console.Write("> " + t[0]);

if (n > 1)
{
    t[1] = 1;
    Console.Write(", " + t[1]);
}

for (int i = 2; i < n; i++)
{
    t[i] = t[i - 2] + t[i - 1];
    Console.Write(", " + t[i]);
}
