class Zadanie7
{
    static void Main(string[] args)
    {
        const int n = 7;
        float[] t = new float[n];
        float max = 0;
        int j = -1;

        Console.WriteLine("Tablica:\n");
        Console.WriteLine("Podaj elementy tablicy:");

        t[0] = Convert.ToSingle(Console.ReadLine());
        t[0] = max;

        for (int i = 1; i < n; i++)
        {
            t[i] = Convert.ToSingle(Console.ReadLine());
            if (t[i] > max)
            {
                max = t[i];
                j = i;
            }
        }
        Console.WriteLine("Indeks maksymalnej liczby rzeczywistej: " + j);
    }
}