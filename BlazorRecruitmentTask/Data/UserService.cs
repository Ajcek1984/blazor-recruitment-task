namespace BlazorRecruitmentTask.Data
{
    public class UserService
    {
        private static readonly User[] Users = new[]
        {
            new User {  Name = "Adam Kowalski", City = "Radom" },
            new User {  Name = "Piotr Piotrowski", City = "Radom" },
            new User {  Name = "Magda Nowakowska", City = "Warszawa" },
            new User {  Name = "Jan Nowak", City = "Radom" }

        };

        public Task<User[]> GetUsersAsync() => Task.FromResult(Users);
    }
}
