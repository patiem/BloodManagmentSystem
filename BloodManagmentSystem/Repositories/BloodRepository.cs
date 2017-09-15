using BloodManagmentSystem.Models;
using BloodManagmentSystem.ViewModels;

namespace BloodManagmentSystem.Repositories
{
    class BloodRepository : IBloodRepository
    {
        private ApplicationDbContext _context;

        public BloodRepository()
        {
            _context = new ApplicationDbContext();
        }
        public BloodRequestFormViewModel Get()
        {
            throw new System.NotImplementedException();
        }

        public void Add()
        {
            throw new System.NotImplementedException();
        }
    }
}