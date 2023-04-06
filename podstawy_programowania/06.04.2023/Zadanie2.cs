const uint n = 7;
uint[] t = new uint[n];
uint suma = 1;

Console.WriteLine("Ciag Fibonacciego:\n");

for (int i = 2; i < n; i++)
{
    t[i] = t[i - 2] + t[i - 1];
    suma += t[i];
}
Console.WriteLine("\nSuma N-pierwszych wynosi: " + suma);
