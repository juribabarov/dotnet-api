namespace dotnet_rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Neuer Character";
        public int HitPoints { get; set; } = 100;
        public int Strength { get; set; } = 5;
        public int Defense { get; set; } = 5;
        public int Intelligence { get; set; } = 5;
        public RpgClass Class { get; set; } = RpgClass.Knight;

        public User User { get; set; }
        public Weapon Weapon { get; set; }
    }
}