# Praca domowa
## Termin
10 lutego 2023 23:59
## Instrukcje
Napisz program, który sprawdza czy numer PESEL jest poprawny.<br>
Algorytm sprawdzania jest następujący:<br>
4 4 0 5 1 4 0 1 3 5 8<br>
a b c d e f g h i j k<br>
PESEL jest poprawny, jeśli:<br>
(10-K) = (1*a + 3*b + 7*c + 9*d + 1*e + 3*f + 7*g + 9*h + 1*i + 3*j) (mod 10)<br>
Przykład dla numeru PESEL 44051401358:<br>
1*4 + 3*4 + 7*0 + 9*5 + 1*1 + 3*4 + 7*0 + 9*1 + 1*3 + 3*5 = 101<br>
Wyznaczamy resztę z dzielenia sumy przez 10: 101/10 = 10 reszta = 1<br>
Jeżeli reszta = 0, to cyfra kontrolna wynosi 0. Jeżeli reszta ≠ 0, to cyfra kontrolna będzie
uzupełnieniem reszty do 10, czyli w podanym przykładzie jest to cyfra 9.<br>
10 - 1 = 9<br>
Wynik 9 nie jest równy ostatniej cyfrze numeru PESEL, czyli 8, więc numer zawiera błąd.