// Polecenie:
// Napisać program realizujący funkcje prostego kalkulatora, pozwalającego na wykonywanie operacji dodawania, odejmowania, mnożenia i dzielenia na dwóch liczbach rzeczywistych. Program ma identyfikować sytuację wprowadzenia błędnego symbolu działania oraz próbę dzielenia przez zero. Zastosować instrukcję switch do wykonania odpowiedniego działania w zależności od wprowadzonego symbolu operacji. Scenariusz działania programu:  
//
// a) Program wyświetla informację o swoim przeznaczeniu.  
// b) Wczytuje pierwszą liczbę.  
// c) Wczytuje symbol operacji arytmetycznej: +, -, *, /.
// d) Wczytuje drugą liczbę.  
// e) Wyświetla wynik lub - w razie konieczności - informację o niemożności wykonania działania.  
// f) Program kończy swoje działanie po naciśnięciu przez użytkownika klawisza Enter. 

class Zadanie6
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cześć, nazywam się kalkulator MEGABIT125, miło mi cię widzieć! :-)\n");
        Console.WriteLine("Wspieram następujące operacje matematyczne:");
        Console.WriteLine("+  -  dodawanie\n-  -  odejmowanie\n*  -  mnożenie\n/  -  dzielenie");

        // while (true) oznacza że pętla będzie działać
        // dopóki program nie zostanie zamknięty lub pętla nie zostanie przerwana.
        while (true)
        {
            // Można utworzyć stringa z powtarzającym się znakiem.
            // Jako argument trzeba podać znak (char) i ilość powtórzeń tego znaku.
            //
            // new string(znak, lizbaPowtorzen);
            Console.Write("\n\n" + new string('-', 16) + "\n\n");

            Console.WriteLine("Podaj pierwszą liczbę:");
            double liczba1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Wpisz symbol operacji matematycznej:");

            // Metoda ReadKey() wczytuje dokładnie 1 klawisz i zwraca o nim informację.
            // Właściwość KeyChar poda ten klawisz w postaci znaku (char)
            // Właściwość Key poda jaki to klawisz w postaci enumeratora ConsoleKey.
            char znak = Console.ReadKey().KeyChar;

            Console.WriteLine("\nPodaj drugą liczbę:");
            double liczba2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            // Switch to taki zbiór instrukcji dla każdej możliwej wartości.
            //
            // case '+' oznacza, że wykona znajdującą się niżej instrukcje
            // pod warunkiem, że zmienna ZNAK jest znakiem +
            switch (znak)
            {
                case '+':
                    // liczba1 += liczba2
                    // to jest to camo co
                    // liczba1 = liczba1 + liczba2
                    //
                    // No tylko że krócej :-)
                    liczba1 += liczba2;

                    // słowo kluczowe break (gdy znajduje się w switchu) daje programowi znać, że znajduje się
                    // tu koniec instrukcji dla tej możliwej wartości
                    break;
                case '-':
                    liczba1 -= liczba2;
                    break;
                case '*':
                    liczba1 *= liczba2;
                    break;
                case '/':
                    if (liczba2 == 0)
                    {
                        Console.WriteLine("Nie dzieli się przez 0!");
                        // Słowo kluczowe continue przeskakuje z tej iteracji pętli do następnej.
                        continue;
                    }
                    liczba1 /= liczba2;
                    break;
                default:
                    Console.WriteLine("Podany symbol operacji matematycznej nie jest wspierany!");
                    // break mozna zamienic slowami kluczowymi continue i return.
                    continue;
            }
            Console.WriteLine("Wynik działania: {0}\n\n", liczba1);
            Console.WriteLine("Wciśnij dowolny klawisz aby kontynuować lub <Enter> aby zakończyć program.");
            
            // Sprawdzamy czy klawisz który uzytkownik wciśnie jest enterem.
            // Jeśli tak to wychodzimy z pętli, w przeciwnym wypadku kontynujemy.
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                // Słowo kluczowe break (gdy znajduje się w pętli) przerywa wykonywanie pętli.
                break;
            }
        }
    }
}