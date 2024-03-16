using BlazorRecruitmentTask.Models;

namespace BlazorRecruitmentTask.Services
{
    public class UserService
    {
        public const string UnasssignedUsersGroup = "UnassignedUsers";
        private static readonly UserModel[] Users = new[]
        {
            new UserModel {  Name = "Adam Kowalski", City = "Radom", Photo="images/user3.png", Group = UnasssignedUsersGroup },
            new UserModel {  Name = "Piotr Piotrowski", City = "Radom", Photo="images/user2.png", Group = UnasssignedUsersGroup },
            new UserModel {  Name = "Magda Nowakowska", City = "Warszawa", Photo="images/user1.png", Group = UnasssignedUsersGroup },
            new UserModel {  Name = "Jan Nowak", City = "Radom", Photo="images/user4.png", Group = "Group1" }

        };

        public Task<UserModel[]> GetUsersAsync() => Task.FromResult(Users);
    }
}
