namespace DataDtore.EF.Models
{
    public class Dog : Pet
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