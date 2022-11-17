namespace WebApplication1.Services.LAB4
{
    public class Polish : Language, ILanguage
    {
        public Polish(string name)
        {
            Name = name;
        }
        public string Name { get; set ; }

        public override string getLang()
        {
            return "pl";
        }

        public string GetLanguageName()
        {
            return Name;
        }

        public override string getLangCode()
        {
            throw new NotImplementedException();
        }

        public override string translate(string key)
        {
            throw new NotImplementedException();
        }
    }
}
