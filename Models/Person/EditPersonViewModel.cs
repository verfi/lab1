using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
namespace MVC_LAB.Models.Person
{
    public class EditPersonViewModel
    {
        public string Name {get; set;}
        public List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem> Gender {get; set;}
        public string City {get; set;}
        public int ID {get; set;}
    }
}