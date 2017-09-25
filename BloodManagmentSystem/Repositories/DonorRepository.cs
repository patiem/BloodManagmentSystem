using BloodManagmentSystem.Models;

namespace BloodManagmentSystem.Repositories
{
    class DonorRepository : IDonorRepository
    {
        private readonly ApplicationDbContext _context;

        public DonorRepository()
        {
            _context = new ApplicationDbContext();
        }

        public void Add(Donor donor)
        {
            _context.Donors.Add(donor);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}