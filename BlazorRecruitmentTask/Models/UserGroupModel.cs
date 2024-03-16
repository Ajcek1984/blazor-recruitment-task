namespace BlazorRecruitmentTask.Models
{
    public class UserGroupModel
    {
        public required string Identifier { get;set; }

        public required string Name { get;set; }

        public required Func<string> Icon { get;set; }


    }
}
