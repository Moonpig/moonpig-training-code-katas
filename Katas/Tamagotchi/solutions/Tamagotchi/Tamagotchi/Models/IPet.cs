namespace Tamagotchi.Models
{
    public interface IPet
    {
        public string Type { get; set; }
        public int Happiness { get; set; }
        public int Hunger { get; set; }
        
        public int Feed();

        public int Pet();
    }
}