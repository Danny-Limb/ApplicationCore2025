using Microsoft.EntityFrameworkCore;
using TestAppCore.DataLayerModels;
using TestAppCore.DBAccess;

namespace TestAppCore
{
    public class MainServices
    {
        private readonly TestApplicatioCoreContext _context;

        public MainServices(TestApplicatioCoreContext context)
        {
            _context = context;
        }


        public List<UserProfile> GetAllUsers()
        {
            var students = _context.UserProfiles.ToList();
            return students;
        }
    }
}
