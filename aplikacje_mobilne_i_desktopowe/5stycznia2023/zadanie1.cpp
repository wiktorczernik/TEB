// Kartkówka 
//
//
// Polecenie:
// Napisz program, w którym zadeklarujesz tablicę 9-elementową. 
// Wartości tablicy mają być wczytane z klawiatury (wprowadzone przez użytkownika). 
// Wartości wyświetl na ekranie w jednym wierszu. 
// 
// Sprawdź czy wartość środkowego elementy czy (czwarty element tablicy) jest większy, 
// mniejszy czy równy średniej arytmetycznej dwóch brzegowych wartości (pierwszego i ostatniego). 
// 
// Wyświetl odpowiedni komunikat.

#include <iostream>
#include <string>

int main()
{
    int tab[9], i;
    std::string out;
    float num;

    std::cout << "Wpisz 9 liczb:\n";
    out += "\nElementy tablicy:\n";
    for (i = 0; i < 9; i++) {
        std::cin >> tab[i];
        out += std::to_string(tab[i]) + "\t";
    }
    out += "\n";
    i = tab[4];
    num = tab[0] + tab[8];
    if (num != 0) {
        num *= 0.5;
    }
    out += "Srodkowy element tablicy jest ";
    if (i > num) {
        out += "wiekszy niz srednia arytmetyczna";
    }
    else if (i < num) {
        out += "mniejszy niz srednia arytmetyczna";
    }
    else {
        out += "rowny sredniej arytmetycznej";
    }
    out += " dwoch brzegowych wartosci";
    std::cout << out;

    return 0;
}