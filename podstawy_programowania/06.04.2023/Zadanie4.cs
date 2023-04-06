class Zadanie4
{
    static void Main(string[] args)
    {
        const int m = 7;
        int[] y = new int[m];

        Console.WriteLine("Tablica Indexowana:\n");

        for (int i = 0; i < m; i++)
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
            Console.Write(y[i]);
            if (i + 1 != m)
            {
                Console.Write(", ");
            }
        }
    }
}