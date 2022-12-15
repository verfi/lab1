using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace MVC_LAB.Models.Person
{
    public class CreatePersonViewModel
    {
        public int ID {get; set;}
        public string Name {get; set;}
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Gender {get; set;}
        public string City {get; set;}

        
    }
}