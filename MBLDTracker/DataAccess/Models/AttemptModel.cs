using static MBLDTracker.FormattingTools;
namespace MBLDTracker.DataAccess.Models
{
    public class AttemptModel
    {
        public int Id { get; set; }
        public int Attempted { get; set; }
        public int Solved { get; set; }
        public int SolvedAtHour { get; set; }
        public string MemoTime { get; set; }
        public string TotalTime { get; set; }
        public string Notes { get; set; }
        public string DateAttempted { get; set; }
        public string CompletedDisplayValue 
        { 
            get
            {

                return $"{Solved}/{Attempted} {TotalTimeDisplayValue}";
                
            } 
        }
        public string PendingDisplayValue 
        { 
            get
            {
                return $"?/{Attempted}              {DateAttempted}";
            } 
        }
        public string HourDisplayValue
        {
            get
            {
                return $"{SolvedAtHour}/{Attempted} 1:00:00";
            }
        }
        public string MemoTimeDisplayValue
        {
            get
            {
                return FormatTime(MemoTime);
            }
        }
        public string TotalTimeDisplayValue
        {
            get
            {
                return FormatTime(TotalTime);
            }
        }
        
        public List<ScrambleModel> Scrambles { get; set; }
        public AttemptModel()
        {

        }
        public AttemptModel(int size)
        {
            Attempted = size;
            DateAttempted = DateTime.Now.ToString();
            Scrambles = new List<ScrambleModel>();
            for(int i = 0; i < Attempted; i++)
            {
                Scrambles.Add(new ScrambleModel());
            }
        }
    }
}