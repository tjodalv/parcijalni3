using Ispit.Konzola.Sucelja;
using Ispit.Konzola;

internal class Program
{
    static void Main(string[] args)
    {
        PametniTelefon telefon = new PametniTelefon("iPhone 15 Plus");
        TestirajTelefon(telefon);
    }

    static void TestirajTelefon(IPametniTelefon telefon)
    {
        Console.WriteLine("Unesite telefonski broj:");
        string broj = Console.ReadLine();

        Console.WriteLine("Unesite URL:");
        string url = Console.ReadLine();

        Console.WriteLine(telefon.Poziv(broj));
        Console.WriteLine(telefon.Surfaj(url));
    }
}