using TestAppCore.DataLayerModels;

namespace TestAppCore
{
    public interface IMainRepositry
    {
        List<UserProfile> GetAllUsers();
    }
}
