namespace AplicacionMVC.Models.Entities
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int Goals { get; set; }
        public int Height { get; set; }
        public int BirthDate { get; set; }
        public int ClubId { get; set; }
    }
}
