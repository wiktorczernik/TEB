// Praca domowa
//
// 
// Polecenie:
// Napisz program, który sprawdza czy numer PESEL jest poprawny.
// 
// Algorytm sprawdzania jest następujący :
// 4 4 0 5 1 4 0 1 3 5 8
// a b c d e f g h i j k
// 
// PESEL jest poprawny, jeśli :
// (10 - K) = (1 * a + 3 * b + 7 * c + 9 * d + 1 * e + 3 * f + 7 * g + 9 * h + 1 * i + 3 * j) (mod 10)
// Przykład dla numeru PESEL 44051401358 :
// 1 * 4 + 3 * 4 + 7 * 0 + 9 * 5 + 1 * 1 + 3 * 4 + 7 * 0 + 9 * 1 + 1 * 3 + 3 * 5 = 101
// 
// Wyznaczamy resztę z dzielenia sumy przez 10 : 101 / 10 = 10 reszta = 1
// Jeżeli reszta = 0, to cyfra kontrolna wynosi 0. Jeżeli reszta ≠ 0, to cyfra kontrolna będzie
// uzupełnieniem reszty do 10, czyli w podanym przykładzie jest to cyfra 9.
// 10 - 1 = 9
// 
// Wynik 9 nie jest równy ostatniej cyfrze numeru PESEL, czyli 8, więc numer zawiera błąd.


#include <iostream>
#include <string>

int main()
{
    std::string pesel;
    std::cout << "Podaj numer PESEL: ";
    std::getline(std::cin, pesel);
    if (pesel.size() != 11) {
        std::cout << "Podano niepoprawny pesel. Numer musi miec dlugosc rowna 11 znakow.";
        return 0;
    }

    int num1 = 1; // exponent (polski jezyk trudny byc)
    int num2 = 0, num3 = 0; // suma i kontrolka

    for (int i = 0; i < 10; ++i) {
        if (pesel[i] < '0' || pesel[i] > '9') {
            std::cout << "Podano niepoprawny PESEL. Numer nie moze zawierac liter lub znakow specjalnych, wylacznie cyfry.";
            return 0;
        }
        num2 += (pesel[i] - '0') * num1;
        if (num1 == 9) {
            num1 = 1;
        }
        else {
            num1 += 2;
            if (num1 == 5) {
                num1 += 2;
            }
        }
    }
    num3 = num2 % 10;
    if (num3 != 0) {
        num3 = 10 - num3;
    }
    bool result = num3 == (pesel[10] - '0');
    std::cout << "Podany numer ";
    if (!result) {
        std::cout << "nie ";
    }
    std::cout << "jest poprawny.";
    return result;
}