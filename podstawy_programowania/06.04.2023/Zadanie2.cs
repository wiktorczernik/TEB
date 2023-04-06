class Zadanie2
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
            suma++;
        }
        for (int i = 2; i < n; i++)
        {
            t[i] = t[i - 2] + t[i - 1];
            suma += t[i];
        }

        Console.WriteLine("\nSuma N-pierwszych wynosi: " + suma);
    }
}