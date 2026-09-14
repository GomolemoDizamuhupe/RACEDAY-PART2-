namespace RACEDAY_PART2_.Models
{
    //I used a different name becaues it was giving me issues when i was connecting to the database(From Route to RaceRoute)
    public class RaceRoutes
    {
        public int RaceRouteId { get; set; }
        public int CategoryId { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int ElevationGain { get; set; }
        public int MapUrl { get; set; }

    }
}
