namespace RACEDAY_PART2_.Models
{
    public class Results
    {
        //setters and getters 
        public int ResultId { get; set; }
        public int EntryId { get; set; }
        public string FinishTime { get; set; }
        public string Position { get; set; }
        public int CapturedBy { get; set; }

    }
}
