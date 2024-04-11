using Microsoft.AspNetCore.Mvc;
using Zadanie5.Database;
using Zadanie5.Models;

namespace Zadanie5.Controllers;
[ApiController]
[Route("[controller]")]
public class VisitController : ControllerBase
{
    [HttpGet]
    [Route("/api/visit/{id:int}")]
    public IActionResult GetVisit(int id)
    {
        List<Visit> pom = new List<Visit>();
        var db = StaticData.VisitList;
        for (int i = 0; i < db.Count; i++)
        {
            if (db[i].Zwierze.Id==id)
            {
                pom.Add(db[i]);
            }
        }
        if (pom.Count>0)
        {
            return Ok(pom);
        }
        return null;
    }

    [HttpPost]
    [Route("api/visit/{idzwierza:int}/{date}/{opis}/{cena:double}")]
    public IActionResult PostVisit(int idzwierza,DateTime date,String opis,double cena)
    {
        var db = StaticData.VisitList;
        var dbAnimal = StaticData.AnimalsList;
        bool istnieje = false;
        for (int i = 0; i < dbAnimal.Count; i++)
        {
            if (dbAnimal[i].Id==idzwierza)
            {
                istnieje = true;
            }
            
        }

        if (istnieje)
        {
            Visit visit = new Visit(dbAnimal[idzwierza],date,opis,cena);
            db.Add(visit);
            return Ok(visit);
        }

        return null;
    }
    
    
}