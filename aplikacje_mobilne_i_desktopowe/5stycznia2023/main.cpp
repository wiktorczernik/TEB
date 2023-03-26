#include <iostream>
#include "zadanie1.cpp"

int main() {
	std::cout << "Lista zadañ:" << "\n* Zadanie 1\n* Zadanie 2\n\n";
	int numer;
	do {
		std::cout << "Wybierz zadanie wpisuj¹c jego numer:";
		std::cin >> numer;
	} 
	while (numer < 1 || numer > 2);
	
	switch (numer) 
	{
		case 1:
			zadanie1::main();
			break;
		case 2:
			//zadanie2::main();
			break;
	}
	return 0;
}