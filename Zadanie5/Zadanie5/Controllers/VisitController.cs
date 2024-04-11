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
    
    
}