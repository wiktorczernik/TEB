#include <iostream>
#include <string>

/*
Klasa - jest to zestaw cech oraz możliwych akcji na podstawie której został zbudowany obiekt.
Obiekt jest reprezentacją klasy lub instancją klasy.

Klasa to inaczej własny typ danych zaprojektowany przez programistę umożliwiający dostęp
do własności (cech) poprzez funkcje składowe klasy (metody).

Metoda - jest to funkcja składowa klasy która ma dostęp do składowych tworząc interfejs.
*/

class Samochod {
public:
    std::string marka;
    std::string model;
    int rocznik;
    float pojemnosc;
    float przyspieszenie;
    float spalanie;

    void dodajSamochod() {
        std::cout << "Podaj marke:";
        std::cin >> marka;
        std::cout << "Podaj model: ";
        std::cin >> model;
        std::cout << "Podaj rocznik: ";
        std::cin >> rocznik;
        std::cout << "Podaj pojemnosc (cm3): ";
        std::cin >> pojemnosc;
        std::cout << "Podaj spalanie: ";
        std::cin >> spalanie;
        std::cout << "Podaj przyspieszenie od 0 do 100 km/h (s): ";
        std::cin >> przyspieszenie;
        std::cout << "\n\n\n";
    }
    void pokazSamochod() {
        std::cout << "Twoj samochod to:\n";
        std::cout << "Marka: " << marka << "\n";
        std::cout << "Model: " << model << "\n";
        std::cout << "Rocznik: " << rocznik << "\n";
        std::cout << "Pojemnosc (cm3): " << pojemnosc << "\n";
        std::cout << "Spalanie: " << spalanie << "\n";
        std::cout << "Przyspieszenie od 0 do 100 km/h (s): " << przyspieszenie << "\n";
    }
};

int main()
{
    Samochod s = Samochod();
    s.dodajSamochod();
    s.pokazSamochod();
}