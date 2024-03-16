namespace BlazorRecruitmentTask.Data
{
    public class UserGroup
    {
        public required string Identifier { get;set; }

        public required string Name { get;set; }

        public required Func<string> Icon { get;set; }


    }
}
