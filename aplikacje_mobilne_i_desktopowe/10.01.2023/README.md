# Zadania - funkcje - 10 stycznia
## Termin
13 stycznia 2023 23:59
## Instrukcje
1. Napisz program, który pobierze z klawiatury trzy wartości, przypisze je pewnym zmiennym, które przekaże jako argumenty funkcjio nazwie **obliczanie**. <br><u>Działanie  funkcji</u>:Jeśli  wartość  pierwszej  zmiennej  pomnożonej  przez  wartość  drugiej zmiennej  jest  większa  od  100-krotności  trzeciej  zmiennej,  to  wynikiem  funkcji  będzie podwojona  wartość  pierwszej  zmiennej,  w  przeciwnym  razie  wynikiem  funkcji  będzie wartość średnia arytmetyczna trzech zmiennych. Wywołaj tę funkcję w programie głównym i wyświetl jej wynik na ekranie.
2. Napisz program zawierający trzy funkcje: 
   - **numer_cwiartki** –funkcja mająca dwa parametry typu całkowitego izwracająca wartość typu całkowitego; 
   - **parzyste** –funkcja mająca dwa parametry typu całkowitego i niezwracająca żadnej wartości;
   - **wyrazenie** –funkcja mająca dwa parametry typu całkowitego i zwracająca wartość typu rzeczywistego;
## Działanie programu
Program prosi użytkownika o podanie dwóch współrzędnych punktu, czyli x oraz y. Następnie ma zostać wywołana funkcja **numer_cwiartki** z argumentami x i y, która zwraca następujące wartości:<br>
<p>1 – gdy punkt należy do pierwszej ćwiartki układu współrzędnych (czyli obie współrzędne są dodatnie); <br>2 – gdy punkt należy do drugiej ćwiartki układu współrzędnych (czyli pierwsza współrzędna jest ujemna, a druga dodatnia);<br>3 – gdy punkt należy do trzeciej  ćwiartki układu współrzędnych  (czyli obie współrzędne są ujemne);<br>4 – gdy punkt należy do czwartej ćwiartki układu współrzędnych (czyli pierwsza współrzędna jest dodatnia, a druga ujemna);<br>0 – gdy punkt leży na jednej z osi układu (czyli jedna ze współrzędnych jest równa 0). </p>

Jeśli funkcja **numer_cwiartki** zwróci wartość 1, to ma zostać wywołana funkcja **parzyste**, która wypisuje liczby parzyste z zakresu od x do y. Jeśli x < y, wypisz liczbyw postaci ciągu rosnącego, w przeciwnym razie w postaci ciągu malejącego.

Jeśli funkcja **numer_cwiartki** zwroci wartość 2 lub 4, to ma zostać wywołana funkcja **wyrazenie**, ktora oblicza wartość wyrażenia 5/(𝑥−𝑦+2). Wyświetl wynik zwracany przez funkcję **wyrazenie.** 

Jeśli funkcja **numer_cwiartki** zwróci wartość 0 lub 3, to wyświetl komunikat *Koniec programu*.