/*
Polecenie:
1. Program ma za zadanie wczytać od użytkownika imię i nazwisko. 
2. Program Ma wyświetlić komunikat: ‘Twoje imię i nazwisko posiadają łącznie: <ilosc_znakow> znaków.‘. 
3. W następnej linii ma zostać wyświetlone imię i nazwisko, jednak każda litera ma zostać odseparowana spacją, zaś w miejsce spacji pomiędzy imieniem i nazwiskiem mają pojawić się 3 spacje. 
4. Należy podać ilość wystąpień wszystkich liter z podanego imienia i nazwiska wedle schematu: 


a – 2 
b – 1 
c – 5 

itd. 


Nie należy podawać liter, które nie zostały wykorzystane. Podobnie należy ignorować znaki 
niedrukowane i specjalne (spacje, wykrzykniki, kropki itp.) 


5. Analogicznie do poprzedniego punktu, należy wyświetlić występujące litery w imieniu i nazwisku, 
po czym wyświetlić jej numer kodowy ASCII 

6. Sumę kodów liter imienia podzielić przez sumę kodowania liter nazwiska. 
W zależności od wyniku należy wyświetlić określone komunikaty: 

wynik > 1 – Twoje imię jest dłuższe niż nazwisko 
wynik < 1 – Twoje imię jest krótsze niż nazwisko 
wynik == 1 – Idealny balans! 

7. Stworzyć pętlę, która będzie wykonywała powyższe zadania do momentu, gdy imię nie będzie równoważne „end”, 
zaś nazwisko „game”. Program ma pożegnać się miłym komunikatem, przykładowo „Do zobaczenia wkrótce!”. 

*/


string name; // imię i nazwisko
int l = 0; // liczba liter
int[] ocr = new int[26]; // liczba występowań znaków (case insensitive)
int[] acr = new int[52]; // liczba występowań znaków (case sensitive)
string s = ""; // imię i nazwisko ze spacjami
string w = ""; // list występowań
string a = ""; // list występowań, ale ascii
int[] an = new int[2]; // suma numerów kodowych ascii imienia i nazwiska.
byte ani = 0; // kursor dla tablicy wyżej

while (true)
{
    // Podpunkt 1.
    Console.WriteLine("Podaj imię i nazwisko");
    name = Console.ReadLine();

    // Podpunkt 7.
    if (name == "end game")
    {
        Console.WriteLine("Do zobaczenia wkrótce!");
        break;
    }

    for (int i = 0; i < name.Length; i++)
    {
        byte c = (byte)name[i];
        bool lc = false;
        if (c > 'Z')
        {
            c -= 32;
            lc = true;
        }
        if (c >= 'A' && c <= 'Z')
        {
            s += name[i];
            l++;
            if (l > 0)
            {
                s += " ";
            }
            c -= 65;
            ocr[c]++;
            acr[c + (lc ? 26 : 0)]++;
            an[ani] += (byte)name[i];
        }
        else if (c == ' ')
        {
            s += "  ";
            ani++;
        }
    }

    // Podpunkt 2.
    Console.WriteLine("Twoje imię i nazwisko posiadają łącznie: {0}", l);

    // Podpunkt 3.
    Console.WriteLine(s);
    s = "";

    // Podpunkt 4.
    for (int i = 0; i < 52; i++)
    {
        if (i < 26)
        {
            if (ocr[i] != 0)
            {
                w += String.Format("\n{0} - {1}", (char)(i + 97), ocr[i]);
                ocr[i] = 0;
            }
        }

        if (acr[i] != 0)
        {
            a += String.Format("\n{0} - {1}", i + (i < 26 ? 65 : 71), acr[i]);
            acr[i] = 0;
        }
    }
    Console.WriteLine("Ilość wystąpień znaków: {0}", w);
    w = "";
    Console.WriteLine("Ilość wystąpień znaków (ASCII): {0}", a);
    a = "";

    // Podpunkt 6.
    if (an[1] != 0)
    {
        float r = an[0] / an[1];
        an[1] = 0;
        if (r < 1)
        {
            Console.WriteLine("wynik < 1 - Twoje imię jest krótsze niż nazwisko");
        }
        else if (r > 1)
        {
            Console.WriteLine("wynik > 1 - Twoje imię jest dłużse niż nazwisko");
        }
        else
        {
            Console.WriteLine("wynik == 1 - Idealny balans!");
        }
    }
    an[0] = 0;

    Console.WriteLine();
}