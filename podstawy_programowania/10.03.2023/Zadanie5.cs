// Polecenie:
// W sklepie ze sprzętem AGD oferowana jest sprzedaż ratalna.
// Napisz program umożliwiający wyliczenie wysokości miesięcznej raty za zakupiony sprzęt.

// Danymi wejściowymi dla programu są:
// • cena towaru (od 100 zł do 10 tyś. zł),
// • liczba rat (od 6 do 48).

// Kredyt jest oprocentowany w zależności od liczby rat:
// • od 6–12 wynosi 2.5% ,
// • od 13–24 wynosi 5%,
// • od 25–48 wynosi 10%.

// Obliczona miesięczna rata powinna zawierać również odsetki.
// Program powinien sprawdzać, czy podane dane
// mieszczą się w określonych powyżej zakresach, a w przypadku błędu
// pytać prosić użytkownika ponownie o podanie danych.

class Zadanie5
{
    static void Main(string[] args)
    {
        double cena;
        int raty;
        double procent;

        //
        do
        {
            Console.WriteLine("Podaj cenę towaru (od 100 do 10000 zł):");
            cena = Convert.ToSingle(Console.ReadLine());
        }
        while (cena < 100 || cena > 10000);
        //
        do
        {
            Console.WriteLine("Podaj liczbę rat (od 6 do 48):");
            raty = Convert.ToInt32(Console.ReadLine());
        }
        while (raty < 6 || raty > 48);


        if (raty < 13)
        {
            // 102,5%, czyli odsetki wynoszą 2,5% ceny.
            procent = 1.025f;
        }
        else if (raty > 24)
        {
            // 110%, czyli odsetki wynoszą 10% ceny.
            procent = 1.1f;
        }
        else
        {
            // 105%, czyli odsetki wynoszą 5% ceny.
            procent = 1.05f;
        }

        // Wysokość miesięcznej raty.
        double miesRata = (cena * procent) / raty;

        miesRata = Math.Round(miesRata * 100) / 100;

        Console.WriteLine("\n\nCena towaru: {0}", cena);
        Console.WriteLine("Liczba rat: {0}\nWysokość miesięcznej raty: {1} zł", raty, miesRata);
    }
}