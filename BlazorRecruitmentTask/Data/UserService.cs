namespace BlazorRecruitmentTask.Data
{
    public class UserService
    {
        public const string UnasssignedUsersGroup = "UnassignedUsers";
        private static readonly User[] Users = new[]
        {
            new User {  Name = "Adam Kowalski", City = "Radom", Photo="images/user3.png", Group = UnasssignedUsersGroup },
            new User {  Name = "Piotr Piotrowski", City = "Radom", Photo="images/user2.png", Group = UnasssignedUsersGroup },
            new User {  Name = "Magda Nowakowska", City = "Warszawa", Photo="images/user1.png", Group = UnasssignedUsersGroup },
            new User {  Name = "Jan Nowak", City = "Radom", Photo="images/user4.png", Group = "Group1" }

        };

        public Task<User[]> GetUsersAsync() => Task.FromResult(Users);
    }
}
