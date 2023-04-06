int silnia;
int sumaS = 1;

Console.WriteLine("Silnia:\n");
Console.Write("Podaj wielkosc silni: ");
silnia = Convert.ToInt32(Console.ReadLine());

if (silnia > 1)
{
    for (int i = 2; i <= silnia; i++)
    {
        sumaS *= i;
    }
    Console.WriteLine("Silnia z n wynosi: " + sumaS);
}
else
{
    Console.WriteLine("Wielkosc silni jest za mala!");
}
