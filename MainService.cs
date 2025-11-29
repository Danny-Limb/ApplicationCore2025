using TestAppCore.DataLayerModels;
using TestAppCore.DBAccess;

namespace TestAppCore
{
    public class MainServices : IMainRepositry
    {
        private readonly TestApplicatioCoreContext _dbcontext;
        public MainServices(TestApplicatioCoreContext dbContext)
        {
            _dbcontext = dbContext;
        }

        public List<UserProfile> GetAllUsers()
        {
            var students = _dbcontext.UserProfiles.ToList();
            return students;
        }
    }
}
