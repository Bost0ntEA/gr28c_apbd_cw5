using Zadanie5.Models;

namespace Zadanie5.Database;

public class StaticData
{
    public static List<Animal> AnimalsList = new List<Animal>()
    {
        new Animal(1, "Burek", "Pies", 15.5, "Czarny"),
        new Animal(2, "Filemon", "Kot", 5.2, "Czarny"),
        new Animal(3, "Puszek", "Kot", 4.8, "Czarny"),
        new Animal(4, "Azor", "Pies", 20.1, "Czarny")
    };

    public static List<Visit> VisitList = new List<Visit>()
    {
        new Visit(AnimalsList[0], DateTime.Now.AddDays(-5), "Szczepienie", 80.0),
        new Visit(AnimalsList[1], DateTime.Now.AddDays(-3), "Kontrola ogólna", 60.0),
        new Visit(AnimalsList[2], DateTime.Now.AddDays(-2), "Badanie krwi", 100.0),
        new Visit(AnimalsList[3], DateTime.Now.AddDays(-1), "Zabieg chirurgiczny", 200.0),
        new Visit(AnimalsList[0], DateTime.Now.AddDays(-1), "Kontrola wzroku", 50.0)
    }; 
}