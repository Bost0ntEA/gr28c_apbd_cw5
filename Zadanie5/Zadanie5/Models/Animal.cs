namespace Zadanie5.Models;

public class Animal
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string Kategoria { get; set; }
    public double Masa { get; set; }
    public string KolorSiersci { get; set; }

    public Animal(int id, string firstName, string kategoria, double masa, string kolorSiersci)
    {
        Id = id;
        FirstName = firstName;
        Kategoria = kategoria;
        Masa = masa;
        KolorSiersci = kolorSiersci;
    }
}


