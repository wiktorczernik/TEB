#include <iostream>

float obliczanie(float a, float b, float c){
    if ((a * b) > (c * 100)){
        return 2 * a;
    }
    return (a + b + c) / 3;
}
int main()
{
    float a, b, c;
    std::cout << "podaj trzy wartosci:" << std::endl;
    std::cin >> a >> b >> c;
    std::cout << "wynik: " << obliczanie(a, b, c);

    return 0;
}