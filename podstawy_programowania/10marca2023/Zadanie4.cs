// Polecenie:
// Napisać program obliczający należny podatek dochodowy od osób fizycznych.
// Program ma pobierać od użytkownika dochód i po obliczeniu
// wypisywać na ekranie należny podatek.
// Podatek obliczany jest wg. następujących reguł:
// • do 85.528 podatek wynosi 18% podstawy minus 556,02 PLN,
// • od 85.528 podatek wynosi 14.839,02 zł + 32% nadwyżki ponad 85.528,00 

class Zadanie4
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj dochód:");
        // Double to jest liczba zmiennoprzecinkowa z podwojoną prezycją (w porównaniu do float).
        double dochod = Convert.ToDouble(Console.ReadLine());
        double podatek;
        if (dochod >= 85528)
        {
            podatek = 14839.02 + 0.32 * (dochod - 85528);
        }
        else
        {
            podatek = 0.18 * dochod - 556.02;
        }
        // Zaokrąglamy do 2 liczby po przecinku, ponieważ nie możemy zapłacić np. połową grosza :-)
        podatek = Math.Round(podatek * 100) / 100;
        Console.WriteLine("Należny podatek wynosi: " + podatek);
    }
}