using BloodManagmentSystem.Models;
using System.Collections.Generic;
using System.Linq;

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

        public IEnumerable<Donor> GetAvailableDonorsWithMatchingBloodType(BloodType bloodType)
        {
            return _context.Donors
                .Where(d => d.BloodType == bloodType)
                .ToList();
        }
    }
}