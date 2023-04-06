uint max = 0;
int maxI = 0;

Console.WriteLine("Tablica:\n");
Console.WriteLine("Podaj elementy tablicy:");

for (int i = 0; i < n; i++)
{
    t[i] = Convert.ToUInt32(Console.ReadLine());
    if (t[i] > max)
    {
        max = t[i];
        maxI = i;
    }
}
Console.WriteLine("Maksymalna liczba rzeczywista: " + max);
Console.WriteLine("Maksymalna liczba rzeczywista (Index): " + maxI);
