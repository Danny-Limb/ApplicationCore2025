using TestAppCore.DataLayerModels;

namespace TestAppCore.BusinessLayer
{
    public interface IMainService
    {
        List<UserProfile> GetAllUsers();
    }
}
