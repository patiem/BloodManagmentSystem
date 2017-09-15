using System.Linq;
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
            var viewModel = new BloodRequestFormViewModel
            {
                Banks = _context.Banks.ToList()
            };
            return viewModel;
        }

        public void Add()
        {
            throw new System.NotImplementedException();
        }
    }
}