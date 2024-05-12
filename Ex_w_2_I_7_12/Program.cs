namespace W_2_I_7_12;
using System.ComponentModel.Design;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Program Działania");

        Console.WriteLine("Podaj pierwszą liczbę");
        int liczba1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Podaj pierwszą liczbę");
        int liczba2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Działania: ");
        Console.WriteLine(" 1. Dodawanie ");
        Console.WriteLine(" 2. Odejmowanie ");
        Console.WriteLine(" 3. Mnożenie ");
        Console.WriteLine(" 4. Dzielenie ");

        Console.WriteLine("Podaj numer działania: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine(liczba1 + liczba2);
                break;
            case 2:
                Console.WriteLine(liczba1 - liczba2);
                break;
            case 3:
                Console.WriteLine(liczba1 * liczba2);
                break;
            case 4:
                Console.WriteLine(liczba1 / liczba2);
                break;

            default:
                Console.WriteLine("Nie ma takiego wyboru");
                break;
        }

    }
}
