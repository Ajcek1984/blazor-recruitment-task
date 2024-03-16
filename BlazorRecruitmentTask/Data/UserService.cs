namespace BlazorRecruitmentTask.Data
{
    public class UserService
    {
        private static readonly User[] Users = new[]
        {
            new User {  Name = "Adam Kowalski", City = "Radom", Photo="images/user3.png" },
            new User {  Name = "Piotr Piotrowski", City = "Radom", Photo="images/user2.png" },
            new User {  Name = "Magda Nowakowska", City = "Warszawa", Photo="images/user1.png" },
            new User {  Name = "Jan Nowak", City = "Radom", Photo="images/user4.png" }

        };

        public Task<User[]> GetUsersAsync() => Task.FromResult(Users);
    }
}
