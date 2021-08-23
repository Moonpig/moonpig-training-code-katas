namespace DataDtore.EF.Models
{
    public class Cat : Pet
    {
        public int Feed()
        {
            return Hunger + 1;
        }

        public int Pet()
        {
            return Happiness + 1;
        }
    }
}