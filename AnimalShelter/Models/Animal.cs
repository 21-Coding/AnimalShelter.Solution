using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace   AnimalShelter.Models
{
    public class Animal
    {
        public int AnimalId {get; set;}
        public string Name {get; set;}
        public int Age {get;  set;}
        public string Type {get; set;}
        
    }
}
