using Zadanie5.Controllers;

namespace Zadanie5.Models;

public class Visit
{
    public Animal Zwierze { get; set; }
    public DateTime DataWizyty { get; set; }
    public String Opis { get; set; }
    public double Cena { get; set; }

    public Visit(Animal zwierze, DateTime dataWizyty, string opis, double cena)
    {
        Zwierze = zwierze;
        DataWizyty = dataWizyty;
        Opis = opis;
        Cena = cena;
    }
}