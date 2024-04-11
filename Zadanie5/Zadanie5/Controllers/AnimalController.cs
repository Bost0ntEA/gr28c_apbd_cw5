using System.Net;
using Microsoft.AspNetCore.Mvc;
using Zadanie5.Database;
using Zadanie5.Models;

namespace Zadanie5.Controllers;
[ApiController]
[Route("[controller]")]
public class AnimalController: ControllerBase
{
    [HttpGet]
    [Route("/api/animals")]
    public IActionResult GetAnimals()
    {
        var db = StaticData.AnimalsList;
        return Ok(db);

    }

    [HttpGet]
    [Route("/api/animals/{id:int}")]
    public IActionResult GetAnimal(int id)
    {
        var db = StaticData.AnimalsList;
        for (int i = 0; i < db.Count; i++)
        {
            if (db[i].Id==id)
            {
                return Ok(db[i]);
            }
            
        }
        return null;
    }

    [HttpPost]
    [Route("api/animals/{id:int}/{firstName}/{kategoria}/{masa:double}/{siersc}")]
    public IActionResult PostAnimal(int id, string firstName, string kategoria, double masa, string siersc)
    {
        var db = StaticData.AnimalsList;
        for (int i = 0; i <db.Count ; i++)
        {
            if (db[i].Id==id)
            {
                throw new HttpRequestException("there is animal with this id");
            }
        }
        var newAnimal = new Animal(id, firstName, kategoria, masa, siersc);
        StaticData.AnimalsList.Add(newAnimal);
        return Ok(newAnimal);
    }

    [HttpDelete]
    [Route("api/animals/{id:int}")]
    public IActionResult DeleteAnimal(int id)
    {
        var db = StaticData.AnimalsList;
        for (int i = 0; i < db.Count; i++)
        {
            if (db[i].Id==id)
            {
                StaticData.AnimalsList.RemoveAt(i);
            }
        }

        return Ok("zwierzak usuniety");
    }
    
    
}