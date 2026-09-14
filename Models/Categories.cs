namespace RACEDAY_PART2_.Models
{
    //I changed the name of the Model from Categories to Category because it was giving an error
    public class Category
    {
        //setters and getters
        public int CategorId { get; set; }
        public int EventId { get; set; }
        public string Name { get; set; }
        public int DistanceKm { get; set; }
        public int MaxParticipants { get; set; }
    }
}
