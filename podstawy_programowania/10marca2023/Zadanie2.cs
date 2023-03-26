// Polecenie:
// Wczytać od użytkownika 3 liczby całkowite i wypisać na ekran
// największą oraz najmniejszą z nich.

class Zadanie2
{
    static void Main(string[] args)
    {
        Console.WriteLine("Wpisz liczbę #1");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wpisz liczbę #2");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Wpisz liczbę #3");
        int c = Convert.ToInt32(Console.ReadLine());

        int max = Math.Max(a, Math.Max(b, c));
        int min = Math.Min(a, Math.Min(b, c));

        Console.WriteLine("Największa: " + max);
        Console.WriteLine("Najmniejsza: " + min);
    }
}