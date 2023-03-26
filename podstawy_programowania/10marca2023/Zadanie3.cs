// Polecenie: Napisać program, który oblicza wartość współczynnika BMI
// (ang. body mass index) wg. wzoru: waga / wzrost2 .
// Jeżeli wynik jest w przedziale (18,5 - 24,9) to wypisuje ”waga prawidłowa”,
// jeżeli poniżej to ”niedowaga”, jeżeli powyżej ”nadwaga”.  

class Zadanie3
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj masę ciała (kg): ");
        float masa = Convert.ToSingle(Console.ReadLine());
        Console.WriteLine("Podaj wzrost (m)f: ");
        float wzrost = Convert.ToSingle(Console.ReadLine());

        // wzrost * wzrost to jest to samo co wzrost2 (wzrost do kwadratu).
        float bmi = masa / (wzrost * wzrost);

        Console.Write("Wynik: ");
        if (bmi > 24.9f)
        {
            Console.Write("Nadwaga.");
        }
        else if (bmi < 18.5f)
        {
            Console.Write("Niedowaga");
        }
        else
        {
            Console.Write("Waga prawidłowa");
        }
    }
}