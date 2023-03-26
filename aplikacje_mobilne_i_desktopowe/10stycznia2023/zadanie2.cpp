#include <iostream>
#include <cmath>

int numer_cwiartki(int a, int b){
    if (a > 0 && b > 0){
        return 1;
    }
    else if (a < 0 && b < 0){
        return 3;
    }
    else if (a < 0 && b > 0){
        return 2;
    }
    else if (a > 0 && b < 0){
        return 4;
    }
    return 0;
}
void parzyste(int a, int b){
    int c, i;
    i = a;
    for (c = 0; c < abs(a - b) + 1;c++){
        if (i % 2 == 0){
            std::cout << i << "\t";
        }
        if (a < b){
            i++;
        }
        else {
            i--;
        }
    }
}
float wyrazenie(int a, int b){
    return 5.0 / (a - b + 2);
}
int x, y, result;
int main()
{
    std::cout << "Podaj wartość X: ";
    std::cin >> x;
    std::cout << "Podaj wartość Y: ";
    std::cin >> y;
    result = numer_cwiartki(x, y);
    if (result == 1){
        std::cout << "Liczby parzyste w zakresie <" << x << ", " << y << ">:\n";
        parzyste(x,y);
    }
    else if (result == 2 || result == 4){
        std::cout << "Wynik wyrazenia: " << wyrazenie(x, y);
    }
    else if (result == 0 || result == 3){
        std::cout << "Koniec programu";
    }
    return 0;
}