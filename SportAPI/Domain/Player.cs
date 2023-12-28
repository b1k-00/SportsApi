namespace SportAPI.Domain
{
    public class Player : BaseEntity
    {

        public string PlayerName { get; set; }

        public int TeamId { get; set; }

        public Team Team { get; set; }
    }
}
