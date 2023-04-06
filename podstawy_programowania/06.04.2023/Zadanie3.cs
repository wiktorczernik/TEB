class Zadanie3
{
    static void Main(string[] args)
    {
        const uint n = 7;
        uint[] t = new uint[n];
        uint suma = 0;

        t[0] = 0;
        if (n > 1)
        {
            t[1] = 1;
        }
        for (int i = 2; i < n; i++)
        {
            t[i] = t[i - 2] + t[i - 1];
            // ewentualnie mo¿na sprawdziæ czy ostatni bit jest zerem
            // if ((t[i] & 1) != 1)
            if (t[i] % 2 == 0)
            {
                suma += t[i];
            }
        }

        Console.WriteLine("Suma parzystych liczb wynosi: " + suma);
    }
}