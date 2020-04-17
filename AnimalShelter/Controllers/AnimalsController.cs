using AnimalShelter.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http.Cors;

namespace AnimalShelter.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
 
  public class AnimalsController : ControllerBase
  {
    private AnimalShelterContext _db;

    public AnimalsController(AnimalShelterContext db)
    {
      _db = db;
    }

    // [EnableCors("Policy1")]
    [HttpGet("{id}")]
    public ActionResult<Animal> Get(int id)
    {
       return _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      
    }

   [HttpGet]
    public ActionResult<IEnumerable<Animal>> Get(string name, int age, string type)
    {
      var query = _db.Animals.AsQueryable();

      if (name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }
      if (type != null)
      {
        query = query.Where(entry => entry.Type == type);
      }

      return query.ToList();
    }


    [HttpPost]
    public void Post([FromBody] Animal animal)
    {
      _db.Animals.Add(animal);
      _db.SaveChanges();
    
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Animal animal)
    {
      animal.AnimalId = id;
      _db.Entry(animal).State = EntityState.Modified;
      _db.SaveChanges();

    }

    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var thisAnimal = _db.Animals.FirstOrDefault(entry => entry.AnimalId == id);
      _db.Animals.Remove(thisAnimal);
      _db.SaveChanges();
     
    }
  }
}