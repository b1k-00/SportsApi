namespace SportAPI.Domain
{
    public class Team : BaseEntity
    {
        public int TeamId { get; set; }

        public string Name { get; set; }

        public List<Player> Players { get; set; }


    }
}
