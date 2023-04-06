class Zadanie5
{
    static void Main(string[] args)
    {
        int sil;
        int ilo = 1;

        Console.WriteLine("Silnia:\n");
        Console.Write("Podaj wielkosc silni: ");
        sil = Convert.ToInt32(Console.ReadLine());

        if (sil < 0)
        {
            Console.WriteLine("Podana wartoœæ nie mo¿e byæ ujemna!");
        }
        else
        {
            Console.Write("Silnia z n wynosi: ");
            if (sil > 1)
            {
                for (int i = 2; i <= sil; i++)
                {
                    ilo *= i;
                }
                Console.Write(ilo);
            }
            else
            {
                Console.Write(1);
            }
        }
    }
}