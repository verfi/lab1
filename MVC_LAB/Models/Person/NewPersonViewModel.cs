namespace MVC_LAB.Models.Person
{
    public class NewPersonViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
            
        public GenderEnum Gender { get; set; }
        public string City { get; set; }
    }
}
