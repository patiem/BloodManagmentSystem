using BloodManagmentSystem.Models;
using BloodManagmentSystem.Repositories;

namespace BloodManagmentSystem.Services
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public IDonorRepository Donors { get; set; }

        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}