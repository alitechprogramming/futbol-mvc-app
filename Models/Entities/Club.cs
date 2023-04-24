namespace AplicacionMVC.Models.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Stadium { get; set; }
        public string CoachName { get; set; }
        public string Location { get; set; }
        public List<Player> Players { get; set; }
    }
}
