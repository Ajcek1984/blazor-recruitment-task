namespace BlazorRecruitmentTask.Models
{
    public class HistoryEntryModel
    {
        public required Func<string> Icon { get;set; }
        public required string Message { get;set; }
    }
}
