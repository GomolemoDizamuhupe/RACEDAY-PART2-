namespace RACEDAY_PART2_.Models
{
    public class Users
    {
        //setters and getters
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; }
    }
}
