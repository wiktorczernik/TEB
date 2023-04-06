const int n = 7;
uint[] t = new int[n];
float max = 0;
float maxI = 0;

Console.WriteLine("Tablica:\n");
Console.WriteLine("Podaj elementy tablicy:");

t[0] = Convert.ToFloat(Console.ReadLine());
t[0] = max;

for (int i = 1; i < n; i++)
{
    t[i] = Convert.ToFloat(Console.ReadLine());
    if (t[i] > max)
    {
        max = t[i];
        maxI = i;
    }
}
Console.WriteLine("Maksymalna liczba rzeczywista: " + max);
Console.WriteLine("Maksymalna liczba rzeczywista (Index): " + maxI);
