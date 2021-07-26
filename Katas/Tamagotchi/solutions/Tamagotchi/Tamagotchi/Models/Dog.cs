namespace Tamagotchi.Models
{
    public class Dog : Pet
    {
        public string Type { get; set; }
        public int Happiness { get; set; }
        public int Hunger { get; set; }
        public int Feed()
        {
            throw new System.NotImplementedException();
        }

        public int Pet()
        {
            throw new System.NotImplementedException();
        }
    }
}