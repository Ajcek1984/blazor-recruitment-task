using BlazorRecruitmentTask.Models;
using MudBlazor;

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

        public UserGroupModel[] Groups { get; } = new[]
        {
            new UserGroupModel { Identifier = "Group1", Name="Grupa 1", Icon= () => Icons.Material.Filled.Star },
            new UserGroupModel { Identifier = "Group2", Name="Grupa 2", Icon= () => Icons.Material.Filled.Face2 },
            new UserGroupModel { Identifier = "Group3", Name="Grupa 3", Icon= () => Icons.Material.Filled.Face },
            new UserGroupModel { Identifier = "Group4", Name="Grupa 4", Icon= () => Icons.Material.Filled.ArrowDropUp },
            new UserGroupModel { Identifier = "Group5", Name="Grupa 5", Icon= () => Icons.Material.Filled.Square }
        };

        public Task<UserModel[]> GetUsersAsync() => Task.FromResult(Users);
    }
}
