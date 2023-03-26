// Kartkówka 
//
//
// Polecenie:
// Napisz program, który wygeneruje liczby z zakresu [5,30] dla dwuwymiarowej tablicy o 5 wierszach i 5 kolumnach. 
// Wyœwietl wartoœci tej tablicy w postaci tabeli. Wyznaczi wyœwietlwartoœæ  maksymaln¹  znajduj¹c¹  siê  na  g³ównej  przek¹tnej.  
// SprawdŸ  czy  wartoœæ  ta  jest podzielna przez 2, 3 czy 5 i wyœwietl odpowiedni komunikat.

#include <stdio.h>
#include <cstdlib>
#include <ctime>
#include <iostream>

int main()
{
    int tab[5][5], i, j, num;

    srand(time(NULL));
    num = 0;
    for (i = 0; i < 5; i++) {
        for (j = 0; j < 5; j++) {
            tab[i][j] = rand() % 26 + 5;
            if (i == j && tab[i][j] > num) {
                num = tab[i][j];
            }
            std::cout << tab[i][j] << "\t";
        }
        std::cout << "\n";
    }
    std::cout << "\nMaksymalna wartosc na glownej przekatnej: " << num << "\n";
    if (num % 2 == 0) {
        std::cout << "Wartosc ta jest podzielna przez 2\n";
    }
    if (num % 3 == 0) {
        std::cout << "Wartosc ta jest podzielna przez 3\n";
    }
    if (num % 5 == 0) {
        std::cout << "Wartosc ta jest podzielna przez 5\n";
    }

    return 0;
}