// Polecenie:
// Napisać program służący do konwersji wartości temperatury
// podanej w stopniach Celsjusza na stopnie w skali Fahrenheita
// (stopnie Fahrenheita = 1.8 * stopnie Celsjusza + 32.0)  

class Zadanie1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj temperaturę w stopniach celsjusza: ");
        float celsius = Convert.ToSingle(Console.ReadLine());
        float fahrenheit = celsius * 1.8f + 32;
        Console.WriteLine("Temperatura w stopniach fahrenheita wynosi: " + fahrenheit);
    }
}