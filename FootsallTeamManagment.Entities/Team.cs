namespace FootsallTeamManagment.Entities
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public KitColor PrimaryKitColor { get; set; }
        public KitColor SecondaryKitColor { get; set; }
    }
    public enum KitColor
    {
        White = 1,
        Red = 2,
        blue = 3,
        yellow = 4,
    }
}
